using PokeBowlWebApplication.Models.Dto;
using System.Data.Entity;

namespace PokeBowlWebApplication
{
    public class PokeDbContext : DbContext
    {
        public PokeDbContext() : base ("PokeConnectionString")
        { }

        public DbSet<MenuCategoryEntity> MenuCategories { get; set; }
        public DbSet<MenuItemEntity> MenuItems { get; set; }
        public DbSet<ItemAddonEntity> ItemAddons { get; set; }
        public DbSet<CartEntity> Carts { get; set; }
        public DbSet<CartLineEntity> CartLines { get; set; }
    }
}