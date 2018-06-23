using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using MegaLight.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace MegaLight.DAL
{
    public class DatabaseContext : DbContext
    {

        public DatabaseContext() : base("DatabaseContext")
        {
        }

        public DbSet<Amount> Amounts { get; set; }
        public DbSet<Average> Averages { get; set; }
        public DbSet<Battery> Batteries { get; set; }
        public DbSet<Light> Lights { get; set; }
        public DbSet<Setting> Settings { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}