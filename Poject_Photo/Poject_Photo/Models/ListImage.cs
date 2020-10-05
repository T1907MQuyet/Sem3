using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Poject_Photo.Models
{
    public class ListImage
    {
        [Key]
        public int ID { get; set; }
        public int CustomerID { get; set; }
        public string ImageLink { get; set; }
        public DateTime Created { get; set; }
        public Boolean Status { get; set; }
        [ForeignKey("CustomerID")]
        public virtual Customer Customer { get; set; }
        public ICollection<OrderDetail> OrderDetails { get; set; }
    }
}