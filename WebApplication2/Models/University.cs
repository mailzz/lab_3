using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class University
    {
        public int UniversityId { get; set; }
        public string Name { get; set; } // название факультета
        public int Rating { get; set; } // успеваемость факультета 
        public ICollection<Professors> Proffesor{ get; set; }
        public ICollection<Directions> Direction { get; set; }
        public ICollection<Sections> Section { get; set; }
        public University()
        {
             Section= new List<Sections>();
        }

    }
}
