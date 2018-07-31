using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalRMessager.Models
{
    public class Manage
    {
        public User User { get; set; }
        public bool InGroup { get; set; } = false;
    }
}