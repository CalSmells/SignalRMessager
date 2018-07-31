using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalRMessager.Models
{
    public class Member
    {
        public SelectList Users { get; set; }
        public string UserId { get; set; }
        public int GroupId { get; set; }
        public string GroupName { get; set; }
        public bool DM { get; set; } = false;
    }
}
