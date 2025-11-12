using Microsoft.AspNetCore.Mvc;

namespace WebAppStocker_1.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Blog()
        {
            ViewData["ActivePage"] = "Blog";
            return View();
        }
    }
}
