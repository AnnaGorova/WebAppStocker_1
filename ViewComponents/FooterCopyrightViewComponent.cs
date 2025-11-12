using Microsoft.AspNetCore.Mvc;
using WebAppStocker_1.Entities;

namespace WebAppStocker_1.ViewComponents
{
    public class FooterCopyrightViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var copyright = new FooterCopyright
            {
                CopyrightYear = DateTime.Now.Year,
                SiteName = "Stocker",
                SiteUrl = "/",
                TemplateCredit = new TemplateCredit
                {
                    DesignerName = "HTML Codex",
                    DesignerUrl = "https://htmlcodex.com",
                    DistributorName = "ThemeWagon",
                    DistributorUrl = "https://themewagon.com"
                }
            };

            return View("FooterCopyright", copyright);
        }
    }
}
