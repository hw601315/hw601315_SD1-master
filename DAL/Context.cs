using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using hw601315_SD1.Models;
using System.Data.Entity;

namespace hw601315_SD1.DAL
{
    public class Context : DbContext 
    {
        public Context() : base("name=DefaultConnection")
        {
            // this method is a 'constructor' and is called when a new context is created
            // the base attribute says which connection string to use

            Database.SetInitializer(new MigrateDatabaseToLatestVersion<Context, hw601315_SD1.Migrations.MISContext.Configuration>("DefaultConnection"));
        }

        public DbSet<Pet> Pets { get; set; }
        public DbSet<Vet> Vets { get; set; }
        public DbSet<Visit> Visits { get; set; }
        //public DbSet<Product> Products { get; set; }
        //public DbSet<OrderDetail> OrderDetails { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }

  

    // Include each object here. The value inside <> is the name of the class,
    // the value outside should generally be the plural of the class name
    // and is the name used to reference the entity in code


}