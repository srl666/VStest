using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using TourismWeb.Models;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace TourismWeb.DAL
{
    // enable-migrations -cntexttypename TourismWeb.DAL.TourismContext -MigrationsDirectory: TourismContextMigrations
    // add-migration -configuration TourismWeb.TourismContextMigrations.Configuration Tables
    // update-database -configuration TourismWeb.TourismContextMigrations.Configuration

    public class TourismContext : DbContext
    {
        public TourismContext() : base("TourismContext")
        {
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Process> Processs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
