using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PokeBowlWebApplication.Models.Dto
{
    public class MenuCategoryEntity
    {
        public int Id { get; set; }
        [Required]
        public string Category { get; set; }
        [Required]
        public string ImgUrl { get; set; } = Global.DefaultFoodImgUrl;
        public string ItemAddonHeading { get; set; }

        // Extras model Modal items
        //Collections
        public List<MenuItemEntity> Items { get; set; } = new List<MenuItemEntity>();
        public List<ItemAddonEntity> ItemAdds { get; set; } = new List<ItemAddonEntity>();
    }
}