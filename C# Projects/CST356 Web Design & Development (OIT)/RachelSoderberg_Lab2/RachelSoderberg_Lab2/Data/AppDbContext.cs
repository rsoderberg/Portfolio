using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using RachelSoderberg_Lab2.Data.Entities;

namespace RachelSoderberg_Lab2.Data
{
    public class AppDbContext : DbContext
    {
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Job> Jobs { get; set; }

        public AppDbContext()
        {
            this.Configuration.LazyLoadingEnabled = false;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer(new AppDbInitializer());
        }
    }

    public class AppDbInitializer : DropCreateDatabaseIfModelChanges<AppDbContext>
    {

    }
}