using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;
using WebMVCApp.Models;

namespace WebMVCApp.ModelConfigurations
{
    public class StudentConfigurations : EntityTypeConfiguration<Student>
    {
        public StudentConfigurations()
        {
            this.ToTable("tbl_students");

            this.HasKey(s => s.Id);

            this.Property(s => s.Id).HasColumnName("student_id").IsRequired();
            this.Property(s => s.Name).HasColumnName("student_name").HasMaxLength(100).IsRequired();
            this.Property(s => s.Address).HasColumnName("student_address").HasMaxLength(100).IsRequired();
            this.Property(s => s.GroupNumber).HasColumnName("student_group_number").HasMaxLength(6).IsRequired();
            this.Property(s => s.CourseNumber).HasColumnName("student_course_number").IsRequired();
        }
    }
}