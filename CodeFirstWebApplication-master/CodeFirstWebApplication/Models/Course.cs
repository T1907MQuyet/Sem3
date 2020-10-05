using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CodeFirstWebApplication.Models 
{
    public class Course
    {
        
        public int CourseID { get; set; }
        public string Title { get; set; }
        public int Creadits { get; set; }
        public virtual ICollection<Enrollment> Enrollments { get; set; }

        public virtual ICollection<Instructor> Instructors { get; set; }


    }
}