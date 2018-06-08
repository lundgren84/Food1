using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PokeBowlWebApplication.Models.Home
{
    public class MenuCategoryViewModel
    {
        public string Category { get; set; }
        public string ImgUrl { get; set; } = "/Resourses/img/Poke/IMAGE_30463.JPG"; /*~/Resourses/img/Poke/IMAGE_30463.JPG*/
        public List<MenuItemViewModel> MenuItems { get; set; }
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

