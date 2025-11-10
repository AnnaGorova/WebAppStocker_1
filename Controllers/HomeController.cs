using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebAppStocker_1.Models;

namespace WebAppStocker_1.Controllers
{
    public class HomeController : Controller
    {
       

        public HomeController(ILogger<HomeController> logger)
        {
           
        }

        public IActionResult Index()
        {
            return View();
        }

    }
}
