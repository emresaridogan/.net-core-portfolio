using Microsoft.AspNetCore.Mvc;
using Portfolio.Business.Concrete;
using Portfolio.DataAccess.EntityFramework;

namespace Portfolio.Presentetion.ViewComponents.Testimonial
{
    public class TestimonialSection : ViewComponent
    {
        TestimonialManager testimonialManager = new TestimonialManager(new EfTestimonialDal());
        public IViewComponentResult Invoke()
        {
            var values = testimonialManager.TGetList();
            return View(values);
        }
    }
}
