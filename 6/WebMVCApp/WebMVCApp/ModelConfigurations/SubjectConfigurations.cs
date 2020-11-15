using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;
using WebMVCApp.Models;

namespace WebMVCApp.ModelConfigurations
{
    public class SubjectConfigurations : EntityTypeConfiguration<Subject>
    {
        public SubjectConfigurations()
        {
            this.ToTable("tbl_subjects");

            this.HasKey(s => s.Id);

            this.Property(s => s.Id).HasColumnName("subject_id").IsRequired();
            this.Property(s => s.Name).HasColumnName("subject_name").IsRequired();
        }
    }
}