using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using SignalRMessager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalRMessager
{
    public class ChatHub : Hub
    {
        private readonly ChatDbContext _context;

        public ChatHub(ChatDbContext context)
        {
            _context = context;
        }

        public async Task SendMessage(int groupId, string userId, string userName, string msg)
        {
            var group = await _context.Group.FindAsync(groupId);

            Message message = new Message { Body = msg, UserId = userId, GroupId = groupId};
            await _context.AddAsync<Message>(message);
            await _context.SaveChangesAsync();

            await Clients.GroupExcept(group.GroupName, Context.ConnectionId).SendAsync("ReceiveExternalMessage", userName, msg);
            await Clients.Caller.SendAsync("ReceiveInternalMessage", msg);
        }

        public async Task SendGeneral(string userId, string userName, string msg)
        {
            await Clients.AllExcept(Context.ConnectionId).SendAsync("ReceiveExternalGeneral", userName, msg);
            await Clients.Caller.SendAsync("ReceiveInternalGeneral", msg);
        }


        public async Task UserOnline(int groupId, string userId)
        {
            var groupUser = await _context.GroupUser.Include(gu => gu.User).Include(gu => gu.Group).FirstOrDefaultAsync(gu => gu.GroupId == groupId && gu.UserId == userId);
            await Groups.AddToGroupAsync(Context.ConnectionId, groupUser.Group.GroupName);
            groupUser.Active = true;
            await _context.SaveChangesAsync();

            await Clients.Group(groupUser.Group.GroupName).SendAsync("UserOnline", userId);
        }

        public async Task UserOffline(int groupId, string userId)
        {
            var groupUser = await _context.GroupUser.Include(gu => gu.Group).Include(gu => gu.User).FirstOrDefaultAsync(gu => gu.GroupId == groupId && gu.UserId == userId);
            await Groups.RemoveFromGroupAsync(Context.ConnectionId, groupUser.Group.GroupName);
            groupUser.Active = false;
            await _context.SaveChangesAsync();

            await Clients.Group(groupUser.Group.GroupName).SendAsync("UserOffline", userId);
        }


        public async Task GetContacts(string userId, string list, string search)
        {
            var user = await _context.User.Include(u => u.GroupUsers).FirstOrDefaultAsync(u => u.Id == userId);
            
            List<GetGroup> getGroups = new List<GetGroup>();
            foreach (var gu in user.GroupUsers)
            {
                if (gu.DM)
                {
                    var ogu = await _context.GroupUser.Include(g => g.User).FirstOrDefaultAsync(g => g.GroupId == gu.GroupId && g.UserId != user.Id && g.User.UserName.Contains(search));
                    if (ogu != null)
                    {
                        GetGroup getGroup = new GetGroup { GroupId = ogu.GroupId, Name = ogu.User.UserName };
                        getGroups.Add(getGroup);
                    }
                }
            }
            await Clients.Caller.SendAsync("GetGroups", getGroups.OrderBy(g => g.Name), list);
        }



        public async Task GetGroups(string userId, string list, string search)
        {
            var user = await _context.User.Include(u => u.GroupUsers).ThenInclude(gu => gu.Group).FirstOrDefaultAsync(u => u.Id == userId);
            var groupUsers = await _context.GroupUser.Where(gu => gu.UserId == userId && gu.Group.GroupName.Contains(search) && gu.DM == false).ToListAsync();


            List<GetGroup> getGroups = new List<GetGroup>();
            foreach (var groupUser in groupUsers)
            {
                GetGroup getGroup = new GetGroup { GroupId = groupUser.GroupId, Name = groupUser.Group.GroupName };
                getGroups.Add(getGroup);
            }
            await Clients.Caller.SendAsync("GetGroups", getGroups.OrderBy(g => g.Name), list);
        }






        

        public async Task AddUser(string userId, int groupId, string userName)
        {
            var group = await _context.Group.FindAsync(groupId);
            GroupUser groupUser = new GroupUser
            {
                User = await _context.User.FindAsync(userId),
                Group = group,
                GroupId = groupId,
                UserId = userId,
                DM = group.DM
            };
            Message message = new Message { UserId = userId, GroupId = groupId, Body = $"{userName} has joined the group" };

            await _context.AddAsync(message);
            await _context.AddAsync(groupUser);
            await _context.SaveChangesAsync();

            await Clients.Groups(group.GroupName).SendAsync("ReceiveExternalMessage", message.Body);
            await Clients.Caller.SendAsync("PostAdd", userId, userName);
        }

        
        public async Task RemoveUser(string userId, int groupId, string userName)
        {
            var groupUser = await _context.GroupUser.Include(gu => gu.Group).FirstOrDefaultAsync(gu => gu.UserId == userId && gu.GroupId == groupId);
            if (groupUser != null)
            {
                Message message = new Message { UserId = userId, GroupId = groupId, Body = $"{userName} has left the group" };
                await _context.AddAsync(message);
                await Clients.Groups(groupUser.Group.GroupName).SendAsync("ReceiveExternalMessage", message.Body);

                _context.Remove(groupUser);
                await _context.SaveChangesAsync();

                await Clients.Caller.SendAsync("PostRemove", userId, userName);
            }
        }
    }
}