using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PracticalWebApplication.Models
{
    public class Contact
    {
        [Key]
        public int ID { get; set; }
        public string NameContact { get; set; }

        public string NumberContact { get; set; }
        public string GroupName { get; set; }
        public DateTime HireDate { get; set; }
        public DateTime Birtday { get; set; }
    }
}