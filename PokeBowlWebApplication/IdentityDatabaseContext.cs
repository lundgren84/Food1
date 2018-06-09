using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PokeBowlWebApplication
{
    public class IdentityDatabaseContext : IdentityDbContext
    {
        public IdentityDatabaseContext() : base("name = PokeConnectionString") { }
    }
}