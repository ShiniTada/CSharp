using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebMVCApp.Models
{
    public class Student
    {
        public Guid Id { get; set; }

        [Display(Name = "Student Name")]
        public string Name { get; set; }

        public string Address { get; set; }

        [Display(Name = "Group")]
        public string GroupNumber { get; set; }

        [Display(Name = "Course Number")]
        public string CourseNumber { get; set; }

        public ICollection<StudentSubjectAttendance> Attendances { get; set; }

    }
}
