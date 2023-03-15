using Microsoft.AspNetCore.Mvc;
using Portfolio.Business.Concrete;
using Portfolio.DataAccess.EntityFramework;
using Portfolio.Entity.Concrete;

namespace Portfolio.Presentetion.Controllers
{
    public class ExperienceController : Controller
    {
        ExperienceManager experienceManager = new ExperienceManager(new EfExperienceDal());
        public IActionResult Index()
        {
            ViewBag.v1 = "Deneyim Listesi";
            ViewBag.v2 = "Deneyimler";
            ViewBag.v3 = "Deneyim Listesi";
            var values = experienceManager.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddExperience()
        {
            ViewBag.v1 = "Deneyim Ekleme";
            ViewBag.v2 = "Deneyimler";
            ViewBag.v3 = "Deneyim Ekleme";
            return View();
        }
        [HttpPost]
        public IActionResult AddExperience(Experience experience)
        {
            experienceManager.TAdd(experience);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteExperience(int id)
        {
            var experience = experienceManager.TGetByID(id);
            experienceManager.TDelete(experience);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateExperience(int id)
        {
            ViewBag.v1 = "Deneyim Güncelleme";
            ViewBag.v2 = "Deneyimler";
            ViewBag.v3 = "Deneyim Güncelleme";
            var values = experienceManager.TGetByID(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateExperience(Experience Experience)
        {
            experienceManager.TUpdate(Experience);
            return RedirectToAction("Index");

        }
    }
}
