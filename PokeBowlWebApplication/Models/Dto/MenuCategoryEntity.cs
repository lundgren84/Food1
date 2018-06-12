using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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


        public List<ShopEntity> Shops { get; set; } = new List<ShopEntity>();
        //Foreign Keys
        //[DisplayName("Shop1 reference Id")]
        //public int Shop1RefId { get; set; }

        //[DisplayName("Shop2 reference Id")]
        //public int Shop2RefId { get; set; }
    }
}