using Microsoft.AspNetCore.Mvc;
using Portfolio.Business.Concrete;
using Portfolio.DataAccess.EntityFramework;

namespace Portfolio.Presentetion.ViewComponents.Introduction
{
    public class IntroductionSection : ViewComponent
    {
        IntroductionManager introductionManager = new IntroductionManager(new EfIntroductionDal());

        public IViewComponentResult Invoke()
        {
            var values = introductionManager.TGetList();
            return View(values);
        }
    }
}
