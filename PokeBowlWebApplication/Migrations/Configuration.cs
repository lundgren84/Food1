namespace PokeBowlWebApplication.Migrations
{
    using PokeBowlWebApplication.Models.Dto;
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<PokeBowlWebApplication.PokeDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(PokeBowlWebApplication.PokeDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            if (!context.Shops.Any())
            {
                var shops = new List<ShopEntity>()
                {
                    new ShopEntity(){ Name = "Empty" },
                    new ShopEntity(){ Name = "Mariapark" },
                    new ShopEntity(){ Name = "Helsingborg City" }
                };
                context.Shops.AddRange(shops);
                context.SaveChanges();
            }
            if (!context.MenuCategories.Any())
            {
                var DefaultCategories = new List<MenuCategoryEntity>()
                {
                      new MenuCategoryEntity()
                      {
                          Category = "Bowls",
                          ItemAddonHeading = "Extras",
                          Items = new List<MenuItemEntity>()
                          {
                             new MenuItemEntity(){ Heading = "Bowl 1", Description = Global.LoremIpsum},
                             new MenuItemEntity(){ Heading = "Bowl 2", Description = Global.LoremIpsum},
                             new MenuItemEntity(){ Heading = "Bowl 3", Description = Global.LoremIpsum},
                          },
                           ItemAdds = new List<ItemAddonEntity>()
                           {
                               new ItemAddonEntity(){ Name = "Extras 1" },
                               new ItemAddonEntity(){ Name = "Extras 2" },
                               new ItemAddonEntity(){ Name = "Extras 3" },
                               new ItemAddonEntity(){ Name = "Extras 4" },
                           }
                      },
                      new MenuCategoryEntity()
                      {
                          Category = "Sallad",
                          ItemAddonHeading = "Extras",
                          Items = new List<MenuItemEntity>()
                          {
                             new MenuItemEntity(){ Heading = "Sallad 1", Description = Global.LoremIpsum},
                             new MenuItemEntity(){ Heading = "Sallad 2", Description = Global.LoremIpsum},
                             new MenuItemEntity(){ Heading = "Sallad 3", Description = Global.LoremIpsum},
                          },
                          ItemAdds = new List<ItemAddonEntity>()
                          {
                               new ItemAddonEntity(){ Name = "Extras 1" },
                               new ItemAddonEntity(){ Name = "Extras 2" },
                               new ItemAddonEntity(){ Name = "Extras 3" },
                               new ItemAddonEntity(){ Name = "Extras 4" },
                          }
                      },
                      new MenuCategoryEntity()
                      {
                          Category = "Dryck",
                          Items = new List<MenuItemEntity>()
                          {
                             new MenuItemEntity(){ Heading = "Dryck 1", Description = Global.LoremIpsum},
                             new MenuItemEntity(){ Heading = "Dryck 2", Description = Global.LoremIpsum},
                             new MenuItemEntity(){ Heading = "Dryck 3", Description = Global.LoremIpsum},
                          }
                      }
                };

                context.MenuCategories.AddRange(DefaultCategories);
            }

            context.SaveChanges();
        }
    }
}
