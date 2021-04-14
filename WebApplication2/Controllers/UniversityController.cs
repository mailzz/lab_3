using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Managers.UniversityManager;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class UniversityController : Controller
    {
        private readonly IUniversityManager Manager;
        public UniversityController(IUniversityManager manager)
        {
            Manager = manager;
        }
        public async Task<IActionResult> University()
        {
            return View(await Manager.GetAll());
        }
        [HttpGet]
        public ViewResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<ActionResult> Create(University university)
        {
            await Manager.Add(university);
            return RedirectToAction(nameof(University));
        }
        [HttpGet]
        public async Task<ActionResult> DeleteUniversity(int id)
        {
            await Manager.DeleteById(id);
            return RedirectToAction(nameof(University));
        }
        [HttpGet]
        public async Task<ViewResult> UpdateUniversity(int id)
        {
            return View(await Manager.GetById(id));
        }

        [HttpPost]
        public async Task<ActionResult> UpdateUniversity(int id, University university)
        {
            await Manager.UpdateById(id, university);
            return RedirectToAction(nameof(university));
        }
    }
}
