using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Poject_Photo.Models
{
    public class ServiceSize
    {
        [Key]
        public int ID { get; set; }
        public string SSName { get; set; }
        public float Price { get; set; }
        public bool Status { get; set; }
        [DisplayFormat(DataFormatString ="{0:dd-MM-yyyy}",ApplyFormatInEditMode =true)]
        public DateTime Created { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}