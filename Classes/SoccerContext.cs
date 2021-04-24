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
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<SoccerContext>(null);
            base.OnModelCreating(modelBuilder);
        }

    }
}
