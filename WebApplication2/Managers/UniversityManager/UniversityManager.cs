using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;

namespace WebApplication2.Managers.UniversityManager
{
    public class UniversityManager : IUniversityManager
    {
        private readonly UniversityContext db = new UniversityContext() ;
        public UniversityManager()
        {
         
        }
        public async Task<University> Add(University university)
        {
            db.university.Add(university);//из context
            await db.SaveChangesAsync();
            return university;
        }

        public async Task DeleteById(int id)
        {
            var university = await this.GetById(id);
            db.university.Remove(university);
            await db.SaveChangesAsync();
        }

        public async Task<IReadOnlyCollection<University>> GetAll()
        {
            var collection = await db.university.ToListAsync();
            return collection;
        }

        public async Task<University> GetById(int id)
        {
            return await db.university.FirstOrDefaultAsync(a => a.UniversityId == id);
        }

        public async Task UpdateById(int id, University university)
        {
            var uni = await this.GetById(id);
            uni.Name = university.Name;
            uni.Rating = university.Rating;
            await db.SaveChangesAsync();
        }

    }
}
