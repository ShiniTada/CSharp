using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebMVCApp.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base("Master")
        {
            Database.SetInitializer(new DbInitializer());
        }

        // DbSet’ы – это коллекции, к которым мы будем обращаться для выполнения операций над данными.
        public DbSet<Student> Students { get; set; }

        public DbSet<StudentSubjectAttendance> Attendance { get; set; }

        public DbSet<Subject> Subjects { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //«собираем» все конфигурации из сборки, в которой находится наш контекст.
            modelBuilder.Configurations.AddFromAssembly(typeof(ApplicationDbContext).Assembly);
        }
    }
}