using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PokeBowlWebApplication.Models.Home
{
    public class MenuItemViewModel
    {
        public int Id { get; set; }
        public string Heading { get; set; } = "The Salmon";
        public string Description { get; set; } = "Wakamesallad, picklad rödlök, sojabönor, inlagd ingefära, gurka, rödkål, rädisor & vårlök. Toppas med chilimajo, teriyakisås och svart masagorom.";
        public decimal Price { get; set; } = 108.0m;
        public string ImgUrl { get; set; } = "/Resourses/img/Poke/IMAGE_30463.JPG";

        //Collections
        public List<MenuItemViewModel> MenuItems { get; set; } = new List<MenuItemViewModel>();

        public ExtrasModalViewModel ExtrasModalModel { get; set; } = new ExtrasModalViewModel()
        {
            Heading = "Extras",
            Extras = new List<ExtrasModel>()
              {
                   new ExtrasModel(),
                   new ExtrasModel(),
                   new ExtrasModel(),
                   new ExtrasModel(),
                   new ExtrasModel(),
                   new ExtrasModel(),
                   new ExtrasModel(),
                   new ExtrasModel(),
                   new ExtrasModel(),
                   new ExtrasModel(),
              }
        };
    }
}