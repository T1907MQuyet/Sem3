using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Poject_Photo.Models
{
    public class Customer
    {
        [Key]
        public int ID { get; set; }
        [StringLength(30,MinimumLength =5,ErrorMessage ="Tên phải từ 5 ký tự đến 30 ký tự..")]
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Avatar { get; set; }
        [DataType(DataType.Password)]
        [StringLength(20,MinimumLength =6,ErrorMessage ="Mật khẩu phải từ 6 ký tự đến 20 ký tự..")]
        public string Password { get; set; }
        public Boolean Status { get; set; }
        public virtual ICollection<ListImage> listImages { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}