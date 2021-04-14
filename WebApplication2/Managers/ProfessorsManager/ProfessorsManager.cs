using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;

namespace WebApplication2.Managers.ProfessorsManager
{
    public class ProfessorsManager : IProfessorsManager
    {
        private readonly UniversityContext db = new UniversityContext();
        public ProfessorsManager()
        {

        }
        public async Task<Professors> Add(Professors professors)
        {
            db.professors.Add(professors);//из context
            await db.SaveChangesAsync();
            return professors;
        }

        public async Task DeleteById(int id)
        {
            var professors = await this.GetById(id);
            db.professors.Remove(professors);
            await db.SaveChangesAsync();
        }

        public async Task<IReadOnlyCollection<Professors>> GetAll()
        {
            var collection = await db.professors.ToListAsync();
            return collection;
        }

        public async Task<Professors> GetById(int id)
        {
            return await db.professors.FirstOrDefaultAsync(a => a.ProfessorsId == id);
        }

        public async Task UpdateById(int id, Professors professors)
        {
            var prof = await this.GetById(id);
            prof.Name = professors.Name;
            prof.subject = professors.subject;
            await db.SaveChangesAsync();
        }
    }
}
