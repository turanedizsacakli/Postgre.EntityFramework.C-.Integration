using PostgreEfCSharpIntegration;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace PostgreCSharpIntegration
{
    public class ShopContext : DbContext
    {
        public DbSet<Product> products { get; set; }
        public ShopContext() : base(nameOrConnectionString: "PGConnectionString")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("public");
            base.OnModelCreating(modelBuilder);
        }

    }
}
