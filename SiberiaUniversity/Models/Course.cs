using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SiberiaUniversity.Models
{
    public class Course
    {
        public Course() { }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CourseID { get; set; }   
        public string Title { get; set; }
        public int Credits { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
