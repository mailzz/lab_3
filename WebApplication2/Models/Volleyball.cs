using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class Volleyball
    {
        [Key]
        [ForeignKey("Sections")]
        public int VolleyballId { get; set; }
        public int Category { get; set; } //число оборудование
        public string Name { get; set; }//название оборудование

        public Sections Sections;


    }
}
