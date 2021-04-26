using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace CourseBD.Class 
{
    public class SoccerContext : DbContext
    {
        public SoccerContext()
       : base("DefaultConnection")
        {  }

        public DbSet<Nomenclature> Nomenclature { get; set; }
        public DbSet<Partner> Partner { get; set; }
        public DbSet<Warehouse> Warehouse { get; set; }
        public DbSet<Employees> Employees { get; set; }
        public DbSet<Currencies> Currencies { get; set; }
        public DbSet<Bills> Bills { get; set; }
        public DbSet<CustomerOrder> CustomerOrder { get; set; }
        public DbSet<CustomerOrderTable> CustomerOrderTable { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<SoccerContext>(null);
            base.OnModelCreating(modelBuilder);
        }

    }
}
