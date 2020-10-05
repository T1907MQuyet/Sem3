using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Poject_Photo.Models
{
    public class City
    {
        [Key]
        public int ID { get; set; }
        public string NameCity { get; set; }
        public Boolean Status { get; set; }
    }
}