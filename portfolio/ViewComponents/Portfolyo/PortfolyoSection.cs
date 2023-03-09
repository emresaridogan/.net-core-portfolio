using Microsoft.AspNetCore.Mvc;
using Portfolio.Business.Concrete;
using Portfolio.DataAccess.EntityFramework;

namespace Portfolio.Presentetion.ViewComponents.Portfolyo
{
    public class PortfolyoSection : ViewComponent
    {
        PortfolyoManager portfolyoManager = new PortfolyoManager(new EfPortfolyoDal());
        public IViewComponentResult Invoke()
        {
            var values = portfolyoManager.TGetList();
            return View(values);
        }
    }
}
