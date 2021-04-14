using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class Students
    {
        public int StudentsId { get; set; }
        public string Name { get; set; }
        public int FirstName { get; set; }
        public int? UniversityId { get; set; }

        public Professors University;
        public ICollection<Sections> Section{ get; set; }
        public Students()
        {
            Section = new List<Sections>();
        }
    }
}
