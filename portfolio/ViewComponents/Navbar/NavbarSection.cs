using Microsoft.AspNetCore.Mvc;

namespace Portfolio.Presentetion.ViewComponents.Navbar
{
    public class NavbarSection : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
