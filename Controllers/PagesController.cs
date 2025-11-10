using Microsoft.AspNetCore.Mvc;

namespace WebAppStocker_1.Controllers
{
    public class PagesController : Controller
    {
        public IActionResult Pages()
        {
            ViewData["ActivePage"] = "Pages";
            return View();
        }

        public IActionResult OurFeatures()
        {
            ViewData["ActivePage"] = "OurFeatures";
            return View();
        }

        public IActionResult OurTeam()
        {
           
            return View();
        }

        public IActionResult Testimonial()
        {

            return View();
        }

        public IActionResult OurOffer()
        {

            return View();
        }

        public IActionResult FAQs()
        {

            return View();
        }

        public IActionResult Page404()
        {

            return View();
        }

    }
}
