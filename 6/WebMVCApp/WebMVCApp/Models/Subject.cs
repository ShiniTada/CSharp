using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebMVCApp.Models
{
    public class Subject
    {
        public Guid Id { get; set; }

        [Display(Name = "Subject")]
        public string Name { get; set; }

        public ICollection<StudentSubjectAttendance> StudentAttendances { get; set; }
    }
}