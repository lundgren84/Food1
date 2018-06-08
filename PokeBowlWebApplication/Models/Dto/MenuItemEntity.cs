using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PokeBowlWebApplication.Models.Dto
{
    public class MenuItemEntity
    {
        public int Id { get; set; }
        public string Heading { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string ImgUrl { get; set; }

        //Foreign Keys
        [DisplayName("MenuCategory reference Id")]
        public int MenuCategoryRefId { get; set; }
        [ForeignKey("MenuCategoryRefId")]
        public virtual MenuCategoryEntity MenuCategory { get; set; }
    }
}