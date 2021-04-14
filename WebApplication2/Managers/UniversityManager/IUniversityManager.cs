using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;

namespace WebApplication2.Managers.UniversityManager
{
   public interface IUniversityManager
    {
        Task<IReadOnlyCollection<University>> GetAll();
        Task<University> Add(University request);

        Task<University> GetById(int id);

        Task UpdateById(int id, University request);

        Task DeleteById(int id);

    }
}
