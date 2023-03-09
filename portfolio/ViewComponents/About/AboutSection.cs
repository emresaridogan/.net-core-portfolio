using Microsoft.AspNetCore.Mvc;
using Portfolio.Business.Concrete;
using Portfolio.DataAccess.EntityFramework;

namespace Portfolio.Presentetion.ViewComponents.About
{
    public class AboutSection : ViewComponent
    {
        AboutManager aboutManager = new AboutManager(new EfAboutDal());
        public IViewComponentResult Invoke()
        {

            var values = aboutManager.TGetList();
            return View(values);
        }
    }
}
