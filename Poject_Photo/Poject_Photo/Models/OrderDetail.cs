using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Poject_Photo.Models
{
    public class OrderDetail
    {
        [Key]
        public int ID { get; set; }
        public int Order_ID { get; set; }
        public int ListImageID { get; set; }
        public int ServiceSizeID { get; set; }
        public float SSizePrice { get; set; }
        public int ServiceMaterialID { get; set; }
        public float SMaterialPrice { get; set; }
        public int Quantity { get; set; }
        [ForeignKey("Order_ID")]
        public virtual Order Order { get; set; }
        [ForeignKey("ListImageID")]
        public virtual ListImage ListImage { get; set; }
        [ForeignKey("ServiceSizeID")]
        public virtual ServiceSize ServiceSize { get; set; }
        [ForeignKey("ServiceMaterialID")]
        public virtual ServiceMaterial ServiceMaterial { get; set; }

    }
}