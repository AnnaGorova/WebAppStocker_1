using Microsoft.AspNetCore.Mvc;

namespace WebAppStocker_1.Controllers
{
    public class ServicesController : Controller
    {
        public IActionResult Services() 
        {
            ViewData["ActivePage"] = "Services";
            return View();
        }
    }
}
