﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeFirstWebApplication.Models
{
    public class Office
    {
        public int ID { get; set; }

        public string Location { get; set; }

        public virtual ICollection<Instructor> Instructors { get; set; }

    }
}