using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeFirst_Web_application.Models
{
    public class Student
    {
       public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public string Address { get; set; }
        public virtual ICollection<Enrollment> Enrollments { get; set; }
        public object FirstMidName { get; internal set; }
    }
}