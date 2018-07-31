using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SignalRMessager.Models
{
    public class Group
    {
        public int GroupId { get; set; }
        public string GroupName { get; set; }
        public bool DM { get; set; } = false;

        //Users Relation
        public ICollection<GroupUser> GroupUsers { get; set; }

        //Messages Relation
        public ICollection<Message> Messages { get; set; }
    }
}
