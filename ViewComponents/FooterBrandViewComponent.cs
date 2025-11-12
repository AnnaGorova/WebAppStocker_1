using Microsoft.AspNetCore.Mvc;
using WebAppStocker_1.Entities;

namespace WebAppStocker_1.ViewComponents
{
    public class FooterBrandViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var brand = new FooterBrand
            {
                LogoText = "Stocker",
                LogoIcon = "fas fa-search-dollar",
                Description = "Dolor amet sit justo amet elitr clita ipsum elitr est.Lorem ipsum dolor sit amet, consectetur adipiscing...",
                AppStore = new StoreLink
                {
                    Url = "#",
                    Icon = "fas fa-apple-alt",
                    SmallText = "Download on the",
                    StoreName = "App Store"
                },
                GooglePlay = new StoreLink
                {
                    Url = "#",
                    Icon = "fas fa-play",
                    SmallText = "Get it on",
                    StoreName = "Google Play"
                }
            };

            return View("FooterBrand", brand);
        }
    }
}