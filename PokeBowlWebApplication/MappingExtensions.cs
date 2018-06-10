using PokeBowlWebApplication.Models.Dto;
using PokeBowlWebApplication.Models.Home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PokeBowlWebApplication
{
    public static class MappingExtensions
    {

        public static MenuCategoryViewModel ToModel(this MenuCategoryEntity entity)
        {
            var model = new MenuCategoryViewModel()
            {
                Category = entity.Category,
                ImgUrl = entity.ImgUrl,
                Id = entity.Id
            };

            model.MenuItems = entity.Items.ToModel(entity);

            return model;
        }

        public static MenuItemViewModel ToModel(this MenuItemEntity entity, MenuCategoryEntity category)
        {
            var model = new MenuItemViewModel()
            {
                Id = entity.Id,
                Heading = entity.Heading,
                Description = entity.Description,
                ImgUrl = entity.ImgUrl,
                Price = entity.Price,
                ExtrasModalModel = new ExtrasModalViewModel()
                {
                    ItemId = entity.Id,
                    Heading = category.ItemAddonHeading,
                    ProductPrice = entity.Price,
                    Extras = category.ItemAdds.Where(x => x.MenuCategoryRefId == entity.MenuCategoryRefId).ToList().ToModel()
                },
            };

            return model;
        }

        public static ExtrasModel ToModel(this ItemAddonEntity entity)
        {
            var model = new ExtrasModel()
            {
                Id = entity.Id,
                Price = entity.Price,
                Name = entity.Name
            };

            return model;
        }

        //List mapping
        public static List<MenuItemViewModel> ToModel(this List<MenuItemEntity> entities, MenuCategoryEntity catalog)
        {
            var modelList = new List<MenuItemViewModel>();
            foreach (var entity in entities)
            {
                modelList.Add(entity.ToModel(catalog));
            }

            return modelList;
        }


        public static List<ExtrasModel> ToModel(this List<ItemAddonEntity> entities)
        {
            var modelList = new List<ExtrasModel>();
            foreach (var entity in entities)
            {
                modelList.Add(entity.ToModel());
            }

            return modelList;
        }

        public static List<MenuCategoryViewModel> ToModel(this List<MenuCategoryEntity> entities)
        {
            var modelList = new List<MenuCategoryViewModel>();
            foreach (var entity in entities)
            {
                modelList.Add(entity.ToModel());
            }

            return modelList;
        }
    }
}