using System.Collections.Generic;

namespace PokeBowlWebApplication.Models.Dto
{
    public class MenuCategoryEntity
    {
        public int Id { get; set; }
        public string Category { get; set; }
        public string ImgUrl { get; set; }
        public string ItemAddonHeading { get; set; }

        // Extras model Modal items
        //Collections
        public List<MenuItemEntity> Items { get; set; } = new List<MenuItemEntity>();
        public List<ItemAddonsEntity> ItemAdds { get; set; } = new List<ItemAddonsEntity>();
    }
}