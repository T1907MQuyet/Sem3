using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using PracticalWebApplication.Models;


namespace PracticalWebApplication.DAL
{
    public class FptPractical:DbContext
    {
        public FptPractical() : base("FptAptechContext") { }
        
        public DbSet<Contact> Contacts { get; set; }
        

    }
}