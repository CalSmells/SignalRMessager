using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalRMessager.Models
{
    public class GetGroup
    {
        public string Name { get; set; }
        public int GroupId { get; set; }
        public string List { get; set; } = "searchList";
    }
}
