using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Managers.ProfessorsManager;
using WebApplication2.Models;

namespace WebApplication2.Controllers 
{
    public class ProfessorsController : Controller
    {
        private readonly IProfessorsManager Manager;
        public ProfessorsController(IProfessorsManager manager)
        {
            Manager = manager;
        }
        public async Task<IActionResult> Professors()
        {
            return View(await Manager.GetAll());
        }
        [HttpGet]
        public ViewResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<ActionResult> Create(Professors professors)
        {
            await Manager.Add(professors);
            return RedirectToAction(nameof(Professors));
        }
        [HttpGet]
        public async Task<ActionResult> DeleteProfessors(int id)
        {
            await Manager.DeleteById(id);
            return RedirectToAction(nameof(Professors));
        }
        [HttpGet]
        public async Task<ViewResult> UpdateProfessors(int id)
        {
            return View(await Manager.GetById(id));
        }

        [HttpPost]
        public async Task<ActionResult> UpdateProfessors(int id, Professors professors)
        {
            await Manager.UpdateById(id, professors);
            return RedirectToAction(nameof(professors));
        }
    }
}
