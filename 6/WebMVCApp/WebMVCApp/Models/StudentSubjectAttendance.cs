using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebMVCApp.Models
{
    public class StudentSubjectAttendance
    {
        public Guid Id { get; set; }

        [Display(Name = "Student Id")]
        public Guid StudentId { get; set; }

        [Display(Name = "Subject Id")]
        public Guid SubjectId { get; set; }

        [Display(Name = "Count Of Misses")]
        public int CountOfMisses { get; set; }

        public Student Student { get; set; }

        public Subject Subject { get; set; }
    }
}