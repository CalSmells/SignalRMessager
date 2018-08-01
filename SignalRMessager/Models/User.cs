using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SignalRMessager.Models
{
    public class User : IdentityUser
    {
        //Group Relation
        public List<GroupUser> GroupUsers { get; set; }
        //Message Relation
        public List<Message> Messages { get; set; }
    }
}