using Microsoft.AspNetCore.Mvc;
using WebAppStocker_1.Entities;

namespace WebAppStocker_1.ViewComponents
{
    public class FooterSupportViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var support = new FooterSupport
            {
                Title = "Support",
                Links = new List<SupportLink>
                {
                    new SupportLink { Text = "Privacy Policy", Url = "#", Icon = "fas fa-angle-right" },
                    new SupportLink { Text = "Terms & Conditions", Url = "#", Icon = "fas fa-angle-right" },
                    new SupportLink { Text = "Disclaimer", Url = "#", Icon = "fas fa-angle-right" },
                    new SupportLink { Text = "Support", Url = "#", Icon = "fas fa-angle-right" },
                    new SupportLink { Text = "FAQ", Url = "#", Icon = "fas fa-angle-right" },
                    new SupportLink { Text = "Help", Url = "#", Icon = "fas fa-angle-right" }
                }
            };

            return View("FooterSupport", support);
        }
    }
}
