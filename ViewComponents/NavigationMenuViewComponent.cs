using System;
using Microsoft.AspNetCore.Mvc;
using WebAppStocker_1.Entities;

namespace WebAppStocker_1.ViewComponents
{
    public class NavigationMenuViewComponent : ViewComponent
    {

        private List<Navigate> _navigateThree;

        public NavigationMenuViewComponent()
        {
            _navigateThree = new List<Navigate>();

            _navigateThree.Add(new Navigate()
            {
                Id = 1,
                Title = "Home",
                Href = "/",
                Order = 1,
                ParentID = null
            });

            Navigate about = new Navigate()
            {
                Id = 2,
                Title = "About",
                Href = "/about/index",
                Order = 2,
                ParentID = null
            };
            //Navigate contactus = new Navigate() 
            //{ 
            //    Id = 3, 
            //    Title = "Contac", 
            //    Href = "/about/contactus", 
            //    ParentID = 2, 
            //    Order = 1 
            //};

            //about.Childs.Add(contactus);


            _navigateThree.Add(about);


            Navigate services = new Navigate()
            {
                Id = 5,
                Title = "Services",
                Href = "/Services/Services",
                ParentID = null,
                Order = 1
            };
            _navigateThree.Add(services);

            Navigate blogs = new Navigate()
            {
                Id = 6,
                Title = "Blogs",
                Href = "/Blog/Blog",
                ParentID = null,
                Order = 1
            };
            _navigateThree.Add(blogs);

            Navigate pages = new Navigate()
            {
                Id = 9,
                Title = "Pages",
                Href = "#",
                ParentID = null,
                Order = 1
            };

            Navigate ourFeatures = new Navigate()
            {
                Id = 10,
                Title = "Our Features",
                Href = "/Pages/OurFeatures",
                ParentID = 10,
                Order = 1
            };
            pages.Childs.Add(ourFeatures);

            Navigate ourTeam = new Navigate()
            {
                Id = 11,
                Title = "Our Team",
                Href = "/Pages/ourTeam",
                ParentID = 10,
                Order = 2
            };
            pages.Childs.Add(ourTeam);

            Navigate testimonial = new Navigate()
            {
                Id = 12,
                Title = "Testimonial",
                Href = "/Pages/Testimonial",
                ParentID = 10,
                Order = 3
            };
            pages.Childs.Add(testimonial);

            Navigate ourOffer = new Navigate()
            {
                Id = 12,
                Title = "Our Offer",
                Href = "/Pages/OurOffer",
                ParentID = 10,
                Order = 4
            };
            pages.Childs.Add(ourOffer);

            Navigate FAQs = new Navigate()
            {
                Id = 12,
                Title = "FAQs",
                Href = "/Pages/FAQs",
                ParentID = 10,
                Order = 5
            };
            pages.Childs.Add(FAQs);

            Navigate page404 = new Navigate()
            {
                Id = 13,
                Title = "404 Page",
                Href = "/Pages/Page404",
                ParentID = 10,
                Order = 6
            };
            pages.Childs.Add(page404);
            _navigateThree.Add(pages);

            Navigate contact = new Navigate()
            {
                Id = 14,
                Title = "Contact",
                Href = "/about/contactus",
                ParentID = null,
                Order = 1
            };
            _navigateThree.Add(contact);


        }




        public IViewComponentResult Invoke()
        {
           return View("NavigationMenu", _navigateThree);
        }



    }

    
}
