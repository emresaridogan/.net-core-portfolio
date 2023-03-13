using Microsoft.AspNetCore.Mvc;

namespace Portfolio.Presentetion.Controllers
{
    public class AdminController : Controller
    {
        public PartialViewResult PartialSideBar()
        {
            return PartialView();
        }        
        public PartialViewResult PartialFooter()
        {
            return PartialView();
        } 
        public PartialViewResult PartialNavbar()
        {
            return PartialView();
        }
        public PartialViewResult PartialHead()
        {
            return PartialView();
        }
        public PartialViewResult PartialScripts()
        {
            return PartialView();
        }public PartialViewResult PartialNavigation()
        {
            return PartialView();
        }
    }
}
