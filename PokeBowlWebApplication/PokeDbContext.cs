using System.Data.Entity;

namespace PokeBowlWebApplication
{
    public class PokeDbContext : DbContext
    {
        public PokeDbContext() : base ("PokeConnectionString")
        {

        }
    }
}