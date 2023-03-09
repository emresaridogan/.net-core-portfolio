using Microsoft.AspNetCore.Mvc;
using Portfolio.Business.Abstract;
using Portfolio.Business.Concrete;
using Portfolio.DataAccess.EntityFramework;

namespace Portfolio.Presentetion.ViewComponents.Service
{
    public class ServiceSection : ViewComponent
    {
        ServiceManager serviceManager = new ServiceManager(new EfServiceDal());
        public IViewComponentResult Invoke()
        {
            var values = serviceManager.TGetList();
            return View(values); 
        }
    }
}
