using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using TestPhotoProject.Models;

namespace TestPhotoProject.DAL
{
    public class ProductDbContext:DbContext
    {
        public ProductDbContext() : base("FptAptechContext1")
        {

        }
        public DbSet<Product> Products { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}