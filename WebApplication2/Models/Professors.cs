using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class Professors
    {
        public int ProfessorsId { get; set; }
        public string Name { get; set; }
        public string subject { get; set; } 
        public int? UniversityId { get; set; }

        public Professors University;
        public ICollection<Groups> Group { get; set; }
        public Professors() 
        {
            Group = new List<Groups>();
        }

    }
}
