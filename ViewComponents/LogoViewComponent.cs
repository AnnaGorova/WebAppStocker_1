using System.Net.Sockets;
using Microsoft.AspNetCore.Mvc;
using WebAppStocker_1.Entities;

namespace WebAppStocker_1.ViewComponents
{
    public class LogoViewComponent : ViewComponent  
    {
        private Option _logoOption;

        public LogoViewComponent()
        {
            _logoOption = new Option()
            {
                Id = 1,
                IsSystem = true,
                Name = "site-logo",
                Value = "Stocker",
                Key = "<i b-ywj0kt3m0b=\"\" class=\"fas fa-search-dollar me-3\"></i>"
            };
        }
        public IViewComponentResult Invoke()
        {
            return View("Logo", _logoOption);
        }

    }
}
