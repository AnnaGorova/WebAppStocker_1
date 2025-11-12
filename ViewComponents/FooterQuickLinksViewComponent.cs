using Microsoft.AspNetCore.Mvc;
using WebAppStocker_1.Entities;

namespace WebAppStocker_1.ViewComponents
{
    public class FooterQuickLinksViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var quickLinks = new FooterQuickLinks
            {
                Title = "Quick Links",
                Links = new List<QuickLink>
                {
                    new QuickLink { Text = "About Us", Url = "#", Icon = "fas fa-angle-right" },
                    new QuickLink { Text = "Feature", Url = "#", Icon = "fas fa-angle-right" },
                    new QuickLink { Text = "Attractions", Url = "#", Icon = "fas fa-angle-right" },
                    new QuickLink { Text = "Tickets", Url = "#", Icon = "fas fa-angle-right" },
                    new QuickLink { Text = "Blog", Url = "#", Icon = "fas fa-angle-right" },
                    new QuickLink { Text = "Contact us", Url = "#", Icon = "fas fa-angle-right" }
                }
            };

            return View("FooterQuickLinks", quickLinks);
        }
    }
}