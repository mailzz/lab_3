using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class Sections
    {
        public int SectionsId { get; set; }
        public int Number { get; set; }
        public string Name { get; set; }
        public int? UniversityId { get; set; }

        public Professors University;

        public Volleyball Volleyball;


    }
}
