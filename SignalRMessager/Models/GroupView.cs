using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SignalRMessager.Models
{
    public class GroupView
    {
        public User CurrentUser { get; set; }
        public int GroupId { get; set; }
        public string GroupName { get; set; }
        public string OtherUserName { get; set; }
        public bool DM { get; set; }

        //Users Relation
        public ICollection<UserAct> Users { get; set; }

        //Messages Relation
        public ICollection<Message> Messages { get; set; }
    }
}
