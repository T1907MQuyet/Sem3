using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstWebApplication.Models
{
    public class Student
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [StringLength(10,ErrorMessage ="Khong duoc qua 10 ky tu")]
        public string LastName { get; set; }
        [StringLength(50, ErrorMessage ="FirstMidName can not be longer 50 characters")]
        [Column("FirstName")]
        [Required]
        public string FirstMidName { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:dd-MM-yyyy)}",ApplyFormatInEditMode =true)]
        [Display(Name ="Enrollment Date")]
        
        public DateTime EnrollmentDate { get; set; }
        public string Address { get; set; }
        public virtual ICollection<Enrollment> Enrollments { get; set; }


    }
}