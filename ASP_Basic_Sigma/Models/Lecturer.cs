﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP_Basic_Sigma.Models
{
    using System.Security.AccessControl;

    public class Lecturer
    {
        public string Name { get; set; }

        public int Id { get; set; }

        public List<Course> Courses { get; set; }
    }
}
