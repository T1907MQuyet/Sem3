using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Web;

namespace CodeFirstWebApplication.Models
{
    public enum Grade
    {
        A,B,C,D
    }
    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public int StudentID { get; set; }
        public int CourseID { get; set; }
        public Grade? Grade { get; set; }
        public virtual Student Student { get; set; }
        public virtual Course Course { get; set; }
    }
}