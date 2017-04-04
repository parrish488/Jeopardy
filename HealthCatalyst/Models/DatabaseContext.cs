using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace HealthCatalyst.Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext()
            : base("DatabaseContext")
        {

        }

        public DbSet<Client> Clients { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}