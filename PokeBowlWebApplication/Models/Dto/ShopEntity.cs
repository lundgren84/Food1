using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PokeBowlWebApplication.Models.Dto
{
    public class ShopEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public List<MenuCategoryEntity> MenuCategories { get; set; } = new List<MenuCategoryEntity>();
    }
}