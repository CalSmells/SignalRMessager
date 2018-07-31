using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalRMessager.Models
{
    public class Message
    {
        public int MessageId { get; set; }
        public string Body { get; set; }

        //User Relation
        public string UserId { get; set; }
        public User User { get; set; }

        //Group Relation
        public int GroupId { get; set; }
    }
}
