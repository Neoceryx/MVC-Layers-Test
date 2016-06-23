using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//References
using System.Data.Entity;
using App.Entities;
using System.Data.Entity.ModelConfiguration.Conventions;
namespace App.DAl
{
    public class SalesDbContext:DbContext
    {
        public SalesDbContext():base("SalesDbConnName")
        {

        }

        public DbSet <Users> Users { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}
