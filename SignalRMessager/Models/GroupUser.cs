using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalRMessager.Models
{
    public class GroupUser
    {
        public int GroupId { get; set; }
        public Group Group { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }
        public bool Active { get; set; } = false;
        public bool DM { get; set; } = false;
    }
}
