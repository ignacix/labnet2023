using Entities;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DataAccess
{
    public partial class NorthwindContext : DbContext
    {
        public NorthwindContext()
            : base("name=NorthwindConnection")
        {
        }

        public virtual DbSet<Categories> Categories { get; set; }
        public virtual DbSet<CustomerDemographics> CustomerDemographics { get; set; }
        public virtual DbSet<Shippers> Shippers { get; set; }
        public object CategorieName { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CustomerDemographics>()
                .Property(e => e.CustomerTypeID)
                .IsFixedLength();
        }
    }
}
