using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.SignalR; 
using Microsoft.EntityFrameworkCore;
using SignalRMessager.Models;

namespace SignalRMessager.Controllers
{
    public class GroupController : Controller
    {
        private readonly ChatDbContext _context;
        private readonly UserManager<User> _userManager;
        private readonly IHubContext<ChatHub> _ChatHubContext;

        public GroupController(ChatDbContext context, UserManager<User> userManager, IHubContext<ChatHub> ChatHubContext)
        {
            _context = context;
            _userManager = userManager;
            _ChatHubContext = ChatHubContext;
        }

        // GET: Groups
        public async Task<IActionResult> Index()
        {
            var GroupAppContext = _context.Group.Include(g => g.GroupUsers).ThenInclude(gu => gu.User);
            var nerd = await _userManager.GetUserAsync(User);
            ViewBag.Id = nerd.Id;
            return View(await _context.Group.ToListAsync());
        }


        [HttpGet("/Group/Group/{groupId}")]
        public async Task<IActionResult> Group(int groupId)
        {

            var user = await _userManager.GetUserAsync(User);
            if (await _context.GroupUser.AnyAsync(gu => gu.UserId == user.Id && gu.GroupId == groupId))
            {
                var group = await _context.Group.Include(g => g.GroupUsers).ThenInclude(gu => gu.User).Include(g => g.Messages).FirstOrDefaultAsync(g => g.GroupId == groupId);
                List<UserAct> users = new List<UserAct>();
                foreach (var gu in group.GroupUsers)
                {
                    UserAct userAct = new UserAct { Id = gu.User.Id, UserName = gu.User.UserName, Active = gu.Active};
                    users.Add(userAct);
                }
                users.OrderBy(u => u.UserName);
                GroupView groupView = new GroupView
                {
                    GroupId = group.GroupId,
                    GroupName = group.GroupName,
                    Messages = group.Messages,
                    Users = users,
                    CurrentUser = user,
                    DM = group.DM
                };
                if (group.DM)
                {
                    var oUser = await _context.GroupUser.Include(gu => gu.User).FirstOrDefaultAsync(gu => gu.User.UserName != user.UserName && gu.GroupId == groupId);
                    groupView.OtherUserName = oUser.User.UserName;
                }
            

                var nerd = await _userManager.GetUserAsync(User);
                ViewBag.Id = nerd.Id;
                return View(groupView);
            }
            return RedirectToAction(nameof(Index));
        }

        //[HttpGet("/Group/AddUser/{groupId}/{dm}")]
        //public async Task<IActionResult> AddUser(int groupId, bool dm)
        //{
        //    if (!dm)
        //    {
        //        Member member = new Member
        //        {
        //            Users = new SelectList(_context.User, "Id", "UserName"),
        //            GroupId = groupId
        //        };

        //        var nerd = await _userManager.GetUserAsync(User);
        //        ViewBag.Id = nerd.Id;
        //        return View(member);
        //    }
        //    return RedirectToAction(nameof(Index));
        //}


        //[HttpPost]
        //public async Task<IActionResult> AddUser(Member member)
        //{
        //    if (member.UserId != "default")
        //    {
        //        //find user
        //        var user = await _context.User.Include(u => u.GroupUsers).ThenInclude(gu => gu.Group).FirstOrDefaultAsync(u => u.Id == member.UserId);
        //        bool nerd = true;
        //        foreach (var gu in user.GroupUsers)
        //        {
        //            if (gu.GroupId == member.GroupId)
        //            {
        //                nerd = false;
        //                break;
        //            }
        //        }
        //        if (nerd)
        //        {
        //            //find group
        //            var group = await _context.Group.Include(u => u.GroupUsers).ThenInclude(gu => gu.User).Include(g => g.Messages).FirstOrDefaultAsync(g => g.GroupId == member.GroupId);

        //            //add stuff
        //            GroupUser groupUser = new GroupUser
        //            {
        //                User = user,
        //                UserId = user.Id,
        //                Group = group,
        //                GroupId = group.GroupId,
        //                DM = member.DM
        //            };

        //            //Create Entrance Message
        //            Message message = new Message { UserId = user.Id, Body = $"{user.UserName} has joined the group" };
        //            group.Messages.Add(message);
        //            await _ChatHubContext.Clients.Groups(group.GroupName).SendAsync("Refresh");

        //            //update the stuff
        //            _context.Add(groupUser);
        //            await _context.SaveChangesAsync();
        //            return RedirectToAction("Index", "Group");
        //        }
        //    }
        //    return RedirectToAction(nameof(AddUser));
        //}



        // GET: Groups/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var @group = await _context.Group
                .FirstOrDefaultAsync(m => m.GroupId == id);
            if (@group == null)
            {
                return NotFound();
            }

           return View(group);
        }


        // GET: Groups/Create
        [HttpGet("/Group/Create/{DM}")]
        public IActionResult Create(bool DM)
        {
            var user = _userManager.GetUserAsync(User);
            var group = new Member
            {
                Users = new SelectList(_context.User, "Id", "UserName"),
                UserId =  user.Id.ToString(),
                DM = DM
            };
            return View(group);
        }
        

        // POST: Groups/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Member member)
        {


            if (ModelState.IsValid)
            {
                var otherUser = await _context.User.Include(u => u.GroupUsers).FirstOrDefaultAsync( u => u.Id == member.UserId);
                var user = await _userManager.GetUserAsync(User);

                if (otherUser.Id == user.Id || member.UserId == "default" || (member.DM && otherUser.GroupUsers.Any(gu => gu.DM == member.DM && gu.UserId == otherUser.Id)))
                {
                    return RedirectToAction(nameof(Create));
                }
                if (member.GroupName == "GroupNameHere" && member.UserId !="default")
                {
                    member.GroupName = $"{otherUser.UserName} - {user.UserName}";
                }
                
                var group = new Group
                {
                    GroupId = member.GroupId,
                    GroupName = member.GroupName,
                    DM = member.DM,
                    GroupUsers = new List<GroupUser>() { }
                };
                
                group.GroupUsers.Add(new GroupUser
                {
                    Group = group,
                    GroupId = member.GroupId,
                    User = otherUser,
                    UserId = member.UserId,
                    DM = member.DM

                });
                group.GroupUsers.Add(new GroupUser
                {
                    Group = group,
                    GroupId = member.GroupId,
                    User = user,
                    UserId = user.Id,
                    DM = member.DM
                });

                
                _context.Add(group);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(member);
        }

        // GET: Groups/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var @group = await _context.Group.FindAsync(id);
            if (@group == null)
            {
                return NotFound();
            }
            return View(@group);
        }

        // POST: Groups/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("GroupId,GroupName")] Group @group)
        {
            if (id != @group.GroupId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(@group);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GroupExists(@group.GroupId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(@group);
        }

        // GET: Groups/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var @group = await _context.Group
                .FirstOrDefaultAsync(m => m.GroupId == id);
            if (@group == null)
            {
                return NotFound();
            }

            return View(@group);
        }

        // POST: Groups/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var @group = await _context.Group.FindAsync(id);
            _context.Group.Remove(@group);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GroupExists(int id)
        {
            return _context.Group.Any(e => e.GroupId == id);
        }
    }
}
