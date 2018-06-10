using PokeBowlWebApplication.Models.Dto;
using System.Collections.Generic;

namespace PokeBowlWebApplication.Models.Home
{
    public class MenuItemViewModel
    {
        public int Id { get; set; }
        public string Heading { get; set; } = "The Salmon";
        public string Description { get; set; } = "Wakamesallad, picklad rödlök, sojabönor, inlagd ingefära, gurka, rödkål, rädisor & vårlök. Toppas med chilimajo, teriyakisås och svart masagorom.";
        public decimal Price { get; set; } = 125m;
        public string ImgUrl { get; set; } = "/Resourses/img/Poke/IMAGE_30463.JPG";
        //Collections
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