using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SignalRMessager.Models;

namespace SignalRMessager.Controllers
{
    public class GroupUsersController : Controller
    {
        private readonly ChatDbContext _context;
        private readonly UserManager<User> _userManager;

        public GroupUsersController(ChatDbContext context, UserManager<User> userManager)
        {
            _context = context;
            _userManager = userManager;
        }


        [HttpGet("/GroupUsers/Index/{groupId}/{dm}")]
        public async Task<IActionResult> Index(int groupId, bool dm)
        {
            if (!dm)
            {
                var users = await _context.User.Include(u => u.GroupUsers).ToListAsync();
                List<Manage> manages = new List<Manage>() { };
                foreach (var user in users)
                {
                    User u = user;
                    manages.Add(new Manage
                    {
                        User = u,
                        InGroup = await _context.GroupUser.AnyAsync(gu => gu.UserId == u.Id && gu.GroupId == groupId)
                    });
                }
                var nerd = await _userManager.GetUserAsync(User);
                ViewBag.Id = nerd.Id;
                ViewBag.GroupId = groupId;
                return View(manages);
            }
            return RedirectToAction("Group", "Group");
        }
        


        // GET: GroupUsers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var groupUser = await _context.GroupUser
                .Include(g => g.Group)
                .Include(g => g.User)
                .FirstOrDefaultAsync(m => m.GroupId == id);
            if (groupUser == null)
            {
                return NotFound();
            }
            
            return View(groupUser);
        }

        // GET: GroupUsers/Create
        public IActionResult Create()
        {
            ViewData["GroupId"] = new SelectList(_context.Group, "GroupId", "GroupId");
            ViewData["UserId"] = new SelectList(_context.User, "Id", "Id");
            return View();
        }

        // POST: GroupUsers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("GroupId,UserId,Active,DM")] GroupUser groupUser)
        {
            if (ModelState.IsValid)
            {
                _context.Add(groupUser);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["GroupId"] = new SelectList(_context.Group, "GroupId", "GroupId", groupUser.GroupId);
            ViewData["UserId"] = new SelectList(_context.User, "Id", "Id", groupUser.UserId);
            return View(groupUser);
        }

        // GET: GroupUsers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var groupUser = await _context.GroupUser.FindAsync(id);
            if (groupUser == null)
            {
                return NotFound();
            }
            ViewData["GroupId"] = new SelectList(_context.Group, "GroupId", "GroupId", groupUser.GroupId);
            ViewData["UserId"] = new SelectList(_context.User, "Id", "Id", groupUser.UserId);
            return View(groupUser);
        }

        // POST: GroupUsers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("GroupId,UserId,Active,DM")] GroupUser groupUser)
        {
            if (id != groupUser.GroupId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(groupUser);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GroupUserExists(groupUser.GroupId))
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
            ViewData["GroupId"] = new SelectList(_context.Group, "GroupId", "GroupId", groupUser.GroupId);
            ViewData["UserId"] = new SelectList(_context.User, "Id", "Id", groupUser.UserId);
            return View(groupUser);
        }

        // GET: GroupUsers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var groupUser = await _context.GroupUser
                .Include(g => g.Group)
                .Include(g => g.User)
                .FirstOrDefaultAsync(m => m.GroupId == id);
            if (groupUser == null)
            {
                return NotFound();
            }

            return View(groupUser);
        }

        // POST: GroupUsers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var groupUser = await _context.GroupUser.FindAsync(id);
            _context.GroupUser.Remove(groupUser);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GroupUserExists(int id)
        {
            return _context.GroupUser.Any(e => e.GroupId == id);
        }
    }
}
