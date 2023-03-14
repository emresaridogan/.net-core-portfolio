using Microsoft.AspNetCore.Mvc;

namespace Portfolio.Presentetion.Controllers
{
    public class IntroductionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
