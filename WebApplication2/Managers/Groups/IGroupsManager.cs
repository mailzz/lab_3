using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;

namespace WebApplication2.Managers.GroupsManager
{
  public  interface IGroupsManager
    {
        Task<IReadOnlyCollection<Groups>> GetAll();
        Task<Groups> Add(Groups request);

        Task<Groups> GetById(int id);

        Task UpdateById(int id, Groups request);

        Task DeleteById(int id);
    }
}
