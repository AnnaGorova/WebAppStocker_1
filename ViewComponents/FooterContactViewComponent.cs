using Microsoft.AspNetCore.Mvc;
using WebAppStocker_1.Entities;

namespace WebAppStocker_1.ViewComponents
{
    public class FooterContactViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var contact = new FooterContact
            {
                Title = "Contact Info",
                ContactInfo = new ContactInfo
                {
                    Address = "123 Street New York.USA",
                    Email = "info@example.com",
                    Phone = "(+012) 3456 7890",
                    Website = "Yoursite@ex.com"
                },
                SocialLinks = new List<SocialLink>
                {
                    new SocialLink {
                    Url = "https://www.facebook.com",
                    Icon = "fab fa-facebook-f",
                    Platform = "Facebook"
                },
                new SocialLink {
                    Url = "https://twitter.com",
                    Icon = "fab fa-twitter",
                    Platform = "Twitter"
                },
                new SocialLink {
                    Url = "https://www.instagram.com",
                    Icon = "fab fa-instagram",
                    Platform = "Instagram"
                },
                new SocialLink {
                    Url = "https://www.linkedin.com",
                    Icon = "fab fa-linkedin-in",
                    Platform = "LinkedIn"
                }
                }
            };

            return View("FooterContact", contact);
        }
    }
}