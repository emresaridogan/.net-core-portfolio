using Microsoft.AspNetCore.Mvc;

namespace Portfolio.Presentetion.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
