﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PokeBowlWebApplication.Models.Dto
{
    public class MenuItemEntity
    {
        public int Id { get; set; }
        [Required]
        public string Heading { get; set; }
        public string Description { get; set; }
        [Required]
        public decimal Price { get; set; } = 0m;
        [Required]
        public string ImgUrl { get; set; } = Global.DefaultLogoImgUrl;

        //Foreign Keys
        [DisplayName("MenuCategory reference Id")]
        public int MenuCategoryRefId { get; set; }
        [ForeignKey("MenuCategoryRefId")]
        public virtual MenuCategoryEntity MenuCategory { get; set; }
    }
}