using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Poject_Photo.Models
{
    public class Order
    {
        [Key]
        public int ID { get; set; }
        public int? CustomerID { get; set; }
        public string PhoneOrder { get; set; }
        public string Address { get; set; }
        public DateTime Created { get; set; }
        public int StatusOrder { get; set; }
        public string CityName { get; set; }
        [StringLength(300)]
        public string Note { get; set; }
        public float TotalPrice { get; set; }
        [ForeignKey("CustomerID")]
        public virtual Customer Customer { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
        
    }
}
