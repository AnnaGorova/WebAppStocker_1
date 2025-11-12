using Microsoft.AspNetCore.Mvc;
using WebAppStocker_1.Entities;

namespace WebAppStocker_1.ViewComponents
{
    [ViewComponent(Name = "TopBar")]
    public class TopBarViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var topBarItems = new List<TopBarItem>
            {
                // Контактна інформація
                new TopBarItem
                {
                    Id = 1,
                    Name = "Find A Location",
                    Value = "Find A Location",
                    Type = "contact",
                    SubType = "address",
                    Icon = "<i class=\"fas fa-map-marker-alt text-primary me-2\"></i>",
                    Order = 1,
                    IsActive = true
                },
                new TopBarItem
                {
                    Id = 2,
                    Name = "Phone",
                    Value = "+01234567890",
                    Type = "contact",
                    SubType = "phone",
                    Icon = "<i class=\"fas fa-phone-alt text-primary me-2\"></i>",
                    Order = 2,
                    IsActive = true,
                    Href = "tel:+01234567890"
                },
                new TopBarItem
                {
                    Id = 3,
                    Name = "Email",
                    Value = "example@gmail.com",
                    Type = "contact",
                    SubType = "email",
                    Icon = "<i class=\"fas fa-envelope text-primary me-2\"></i>",
                    Order = 3,
                    IsActive = true,
                    Href = "mailto:example@gmail.com"
                },

                // Авторизація
                new TopBarItem
                {
                    Id = 4,
                    Name = "Register",
                    Value = "Register",
                    Type = "auth",
                    SubType = "register",
                    Icon = "<i class=\"fa fa-user text-primary me-2\"></i>",
                    Order = 1,
                    IsActive = true,
                    Href = "#"
                },
                new TopBarItem
                {
                    Id = 5,
                    Name = "Login",
                    Value = "Login",
                    Type = "auth",
                    SubType = "login",
                    Icon = "<i class=\"fa fa-sign-in-alt text-primary me-2\"></i>",
                    Order = 2,
                    IsActive = true,
                    Href = "#"
                },

                // Dashboard меню
                new TopBarItem
                {
                    Id = 6,
                    Name = "My Dashboard",
                    Value = "My Dashboard",
                    Type = "auth",
                    SubType = "dashboard",
                    Icon = "<i class=\"fa fa-home text-primary me-2\"></i>",
                    Order = 3,
                    IsActive = true,
                    Href = "#"
                },

                // Пункти випадаючого меню Dashboard
                new TopBarItem
                {
                    Id = 7,
                    Name = "My Profile",
                    Value = "My Profile",
                    Type = "dashboard",
                    SubType = "menu-item",
                    Icon = "<i class=\"fas fa-user-alt me-2\"></i>",
                    Order = 1,
                    IsActive = true,
                    Href = "#"
                },
                new TopBarItem
                {
                    Id = 8,
                    Name = "Inbox",
                    Value = "Inbox",
                    Type = "dashboard",
                    SubType = "menu-item",
                    Icon = "<i class=\"fas fa-comment-alt me-2\"></i>",
                    Order = 2,
                    IsActive = true,
                    Href = "#"
                },
                new TopBarItem
                {
                    Id = 9,
                    Name = "Notifications",
                    Value = "Notifications",
                    Type = "dashboard",
                    SubType = "menu-item",
                    Icon = "<i class=\"fas fa-bell me-2\"></i>",
                    Order = 3,
                    IsActive = true,
                    Href = "#"
                },
                new TopBarItem
                {
                    Id = 10,
                    Name = "Account Settings",
                    Value = "Account Settings",
                    Type = "dashboard",
                    SubType = "menu-item",
                    Icon = "<i class=\"fas fa-cog me-2\"></i>",
                    Order = 4,
                    IsActive = true,
                    Href = "#"
                },
                new TopBarItem
                {
                    Id = 11,
                    Name = "Log Out",
                    Value = "Log Out",
                    Type = "dashboard",
                    SubType = "menu-item",
                    Icon = "<i class=\"fas fa-power-off me-2\"></i>",
                    Order = 5,
                    IsActive = true,
                    Href = "#"
                }
            };

            return View("TopBar", topBarItems);
        }
    }
}