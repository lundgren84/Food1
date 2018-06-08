using PokeBowlWebApplication.Models.Home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PokeBowlWebApplication.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var model = new HomeViewModel()
            {
                MenuCategories = new List<MenuCategoryViewModel>()
                     {
                          new MenuCategoryViewModel()
                          {
                               Category= "Bowls",
                                MenuItems= new List<MenuItemViewModel>()
                                {
                                    new MenuItemViewModel(){Id = 1,Heading="The Salmon" },
                                    new MenuItemViewModel(){Id = 2,Heading="The Tuna" },
                                    new MenuItemViewModel(){Id = 3,Heading="The Veggie" },
                                }
                          },
                           new MenuCategoryViewModel()
                          {
                               Category= "Sallad",
                                   MenuItems= new List<MenuItemViewModel>()
                                {
                                    new MenuItemViewModel(){Id = 4,Heading="Chop chop sallad" },
                                    new MenuItemViewModel(){Id = 5,Heading="Greek sallad" },
                                    new MenuItemViewModel(){Id = 6,Heading="Veggie sallad" },
                                }
                          },
                            new MenuCategoryViewModel()
                          {
                               Category= "Dryck",
                                   MenuItems= new List<MenuItemViewModel>()
                                {
                                    new MenuItemViewModel(){Id = 7,Heading="Cola" },
                                    new MenuItemViewModel(){Id = 8,Heading="Fanta" },
                                    new MenuItemViewModel(){Id = 9,Heading="Sprite" },
                                }
                          },
                     }
            };
            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}