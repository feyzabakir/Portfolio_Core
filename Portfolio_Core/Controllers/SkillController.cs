using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio_Core.Controllers
{
    public class SkillController : Controller
    {
        SkillManager skillManager = new SkillManager(new EfSkillDal());

        public IActionResult Index()
        {
            ViewBag.v1 = "Skill List";
            ViewBag.v2 = "Skills";
            ViewBag.v3 = "Skill List";
            var values = skillManager.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddSkill()
        {
            ViewBag.v1 = "Add Skill";
            ViewBag.v2 = "Skills";
            ViewBag.v3 = "Add Skill";
            return View();
        }
        [HttpPost]
        public IActionResult AddSkill(Skill s)
        {
            skillManager.TAdd(s);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteSkill(int id)
        {
            var values = skillManager.TGetByID(id);
            skillManager.TDelete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditSkill(int id)
        {
            ViewBag.v1 = "Edit Skill";
            ViewBag.v2 = "Skills";
            ViewBag.v3 = "Edit Skill";
            var values = skillManager.TGetByID(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult EditSkill(Skill s)
        {
            skillManager.TUpdate(s);
            return RedirectToAction("Index");
        }
    }
}
