using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;

namespace WebApplication2.Managers.GroupsManager
{
 
        public class GroupsManager : IGroupsManager
        {
            private readonly UniversityContext db = new UniversityContext();
            public GroupsManager()
            {

            }
            public async Task<Groups> Add(Groups groups)
            {
                db.groups.Add(groups);//из context
                await db.SaveChangesAsync();
                return groups;
            }

            public async Task DeleteById(int id)
            {
                var groups = await this.GetById(id);
                db.groups.Remove(groups);
                await db.SaveChangesAsync();
            }

            public async Task<IReadOnlyCollection<Groups>> GetAll()
            {
                var collection = await db.groups.ToListAsync();
                return collection;
            }

            public async Task<Groups> GetById(int id)
            {
                return await db.groups.FirstOrDefaultAsync(a => a.GroupsId == id);
            }

            public async Task UpdateById(int id, Groups groups)
            {
                var group = await this.GetById(id);
                group.Name = groups.Name;
                group.number = groups.number;
                await db.SaveChangesAsync();
            }
        }

}

