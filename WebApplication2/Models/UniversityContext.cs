using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class UniversityContext : DbContext
    {
        public DbSet<University> university { get; set; }
        public DbSet<Professors> professors { get; set; }
        public DbSet<Groups> groups { get; set; }
       
    }
}
