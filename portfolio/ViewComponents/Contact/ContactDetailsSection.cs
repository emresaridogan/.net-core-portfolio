using Microsoft.AspNetCore.Mvc;
using Portfolio.Business.Concrete;
using Portfolio.DataAccess.EntityFramework;

namespace Portfolio.Presentetion.ViewComponents.Contact
{
    public class ContactDetailsSection : ViewComponent
    {
        ContactManager contactManager = new ContactManager(new EfContactDal());
        public IViewComponentResult Invoke()
        {
            var values = contactManager.TGetList();
            return View(values);
        }
    }
}
