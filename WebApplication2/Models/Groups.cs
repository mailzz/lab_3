using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class Groups
    {
        public int GroupsId { get; set; }
        public string Name { get; set; }
        public int number{ get; set; }

        public ICollection<Professors> Professor { get; set; }
        public Groups()
        {
            Professor = new List<Professors>();
        }
    }
}
