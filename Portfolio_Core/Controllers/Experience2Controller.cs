using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio_Core.Controllers
{
    public class Experience2Controller : Controller
    {
        ExperienceManager experienceManager = new ExperienceManager(new EfExperienceDal());
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ListExperience()
        {
            var values = JsonConvert.SerializeObject(experienceManager.TGetList());
            return Json(values);
        }
        [HttpPost]
        public IActionResult AddExperience(Experience p)
        {
            experienceManager.TAdd(p);
            var values = JsonConvert.SerializeObject(p);
            return Json(values);
        }
        public IActionResult GetById(int ExperienceID)
        {
            var v = experienceManager.TGetByID(ExperienceID);
            var values = JsonConvert.SerializeObject(v);
            return Json(values);
        }
        public IActionResult DeleteExperience(int id)
        {
            var v = experienceManager.TGetByID(id);
            experienceManager.TDelete(v);
            return NoContent();
        }
        public IActionResult UpdateExperince(Experience p)
        {
            var existingExperience = experienceManager.TGetByID(p.ExperienceID);
            existingExperience.Name = p.Name;
            existingExperience.ImageUrl = p.ImageUrl;
            existingExperience.Date = p.Date;
            existingExperience.Description = p.Description;
            experienceManager.TUpdate(existingExperience);
            var updatedValues = JsonConvert.SerializeObject(existingExperience);
            return Json(updatedValues);
        }
    }
}
