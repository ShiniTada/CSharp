using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;
using WebMVCApp.Models;

namespace WebMVCApp.ModelConfigurations
{
    public class StudentSubjectAttendanceConfigurations : EntityTypeConfiguration<StudentSubjectAttendance>
    {
        public StudentSubjectAttendanceConfigurations()
        {
            this.ToTable("tbl_student_subject_attendance");

            this.HasKey(ssa => ssa.Id);

            this.Property(ssa => ssa.Id).HasColumnName("id").IsRequired();
            this.Property(ssa => ssa.StudentId).HasColumnName("student_id").IsRequired();
            this.Property(ssa => ssa.SubjectId).HasColumnName("subject_id").IsRequired();
            this.Property(ssa => ssa.CountOfMisses).HasColumnName("count_of_misses").IsRequired();

            //attendance обязательно имеет student, а у student могут быть много attendance
            this.HasRequired(ssa => ssa.Student)
                .WithMany(s => s.Attendances)
                .HasForeignKey(ssa => ssa.StudentId)
                .WillCascadeOnDelete(true);

            //attendance обязательно имеет subject, а у subject могут быть много attendance
            this.HasRequired(ssa => ssa.Subject)
                .WithMany(s => s.StudentAttendances)
                .HasForeignKey(ssa => ssa.SubjectId)
                .WillCascadeOnDelete(true);

            //after enable-migrations
            //then Add-Migration InitialExample
            //and then Update-Database
        }
    }
}