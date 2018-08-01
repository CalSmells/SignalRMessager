using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SignalRMessager.Models;

namespace SignalRMessager.Models
{
    public class ChatDbContext : IdentityDbContext
    {
        public ChatDbContext(DbContextOptions<ChatDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Group>()
                .HasMany(g => g.GroupUsers);
            modelBuilder.Entity<User>()
                .HasMany(u => u.GroupUsers);
            modelBuilder.Entity<GroupUser>()
                .HasKey(gu => new {gu.GroupId, gu.UserId });
            modelBuilder.Entity<Message>()
                .HasOne(m => m.User);
            modelBuilder.Entity<Message>()
                .HasOne(m => m.Group);
        }

        public DbSet<SignalRMessager.Models.Group> Group { get; set; }
        public DbSet<SignalRMessager.Models.User> User { get; set; }
        public DbSet<SignalRMessager.Models.Message> Message { get; set; }
        public DbSet<SignalRMessager.Models.GroupUser> GroupUser { get; set; }
    }
}
