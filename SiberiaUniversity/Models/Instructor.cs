﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SiberiaUniversity.Models
{
    public class Instructor : Person
    {
        [DataType(DataType.Date), Display(Name = "Hire Date"), DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime HireDate { get; set; }

        public ICollection<CourseAssignment> CourseAssignments { get; set; }
        public OfficeAssignment OfficeAssignment { get; set; }
    }
}
