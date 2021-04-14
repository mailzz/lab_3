using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class Directions
    {
        public int DirectionsId { get; set; } // пердметы
        public string group { get; set; } // название пердмета
        public int nubmer { get; set; } // количество часов в направлении 
        public int? UniversityId { get; set; }

        public Professors University;
        public ICollection<Students> Student { get; set; }
        public Directions()
        {
            Student = new List<Students>();
        }

    }
}
