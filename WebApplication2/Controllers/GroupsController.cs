using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Managers.GroupsManager;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class GroupsController : Controller
    {
        private readonly IGroupsManager Manager;
        public GroupsController(IGroupsManager manager)
        {
            Manager = manager;
        }
        public async Task<IActionResult> Groups()
        {
            return View(await Manager.GetAll());
        }
        [HttpGet]
        public ViewResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<ActionResult> Create(Groups groups)
        {
            await Manager.Add(groups);
            return RedirectToAction(nameof(Groups));
        }
        [HttpGet]
        public async Task<ActionResult> DeleteGroups(int id)
        {
            await Manager.DeleteById(id);
            return RedirectToAction(nameof(Groups));
        }
        [HttpGet]
        public async Task<ViewResult> UpdateGroups(int id)
        {
            return View(await Manager.GetById(id));
        }

        [HttpPost]
        public async Task<ActionResult> UpdateGroups(int id, Groups groups)
        {
            await Manager.UpdateById(id, groups);
            return RedirectToAction(nameof(groups));
        }
    }

}

