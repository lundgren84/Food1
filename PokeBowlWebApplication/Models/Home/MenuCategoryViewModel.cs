using PokeBowlWebApplication.Models.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PokeBowlWebApplication.Models.Home
{
    public class MenuCategoryViewModel
    {
        public int Id { get; set; }
        public string Category { get; set; }
        public string ImgUrl { get; set; }
        public List<MenuItemViewModel> MenuItems { get; set; } = new List<MenuItemViewModel>();
    }
}

