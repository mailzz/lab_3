using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;

namespace WebApplication2.Managers.ProfessorsManager
{
    public interface IProfessorsManager
    {
        Task<IReadOnlyCollection<Professors>> GetAll();
        Task<Professors> Add(Professors request);

        Task<Professors> GetById(int id);

        Task UpdateById(int id, Professors request);

        Task DeleteById(int id);
    }
}
