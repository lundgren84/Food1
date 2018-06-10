using PokeBowlWebApplication.Models.Home;
using System.Collections.Generic;
using System.Web.Mvc;
using System.Data.Entity;
using System.Linq;
using System;

namespace PokeBowlWebApplication.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var model = CreateModel();
      

            return View(model);
        }

        private HomeViewModel CreateModel()
        {
            using (var db = new PokeDbContext())
            {
                var menuCategories = db.MenuCategories.
                    Include(x => x.Items).
                    Include(x => x.ItemAdds).ToList();

                var model = new HomeViewModel
                {
                    MenuCategories = menuCategories.ToModel()
                };

                return model;
            }    
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