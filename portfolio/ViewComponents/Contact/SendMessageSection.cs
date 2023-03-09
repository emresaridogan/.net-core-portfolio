using Microsoft.AspNetCore.Mvc;
using Portfolio.Business.Concrete;
using Portfolio.DataAccess.EntityFramework;

namespace Portfolio.Presentetion.ViewComponents.Contact
{
    public class SendMessageSection : ViewComponent
    {

        MessageManager messageManager = new MessageManager(new EfMessageDal());

        public IViewComponentResult Invoke()
        {
            return View();
        }
        //[HttpPost]
        //public IViewComponentResult Invoke(Message p)
        //{
        //    p.Date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
        //    p.Status = true;
        //    messageManager.TAdd(p);
        //    return View();
        //}
    }
}
