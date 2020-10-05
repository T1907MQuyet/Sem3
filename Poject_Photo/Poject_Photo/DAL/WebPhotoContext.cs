using Poject_Photo.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Poject_Photo.DAL
{
    public class WebPhotoContext : DbContext
    {
        public WebPhotoContext() : base("name=newConnection") { }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<ListImage> ListImages { get; set; }
        public DbSet<Order> Orders { get; set; }
        public  DbSet<ServiceSize> ServiceSizes { get; set; }
        public  DbSet<ServiceMaterial> ServiceMaterials { get; set; }
        public  DbSet<City> Cities { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
       

    }
}