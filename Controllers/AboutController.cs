using Microsoft.AspNetCore.Mvc;

namespace WebAppStocker_1.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            ViewData["ActivePage"] = "About";
            return View();
        }

        public IActionResult ContactUs()
        {
            ViewData["ActivePage"] = "ContactUs";
            return View();
        }
    }
}
