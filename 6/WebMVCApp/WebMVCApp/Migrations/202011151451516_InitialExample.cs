namespace WebMVCApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialExample : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tbl_student_subject_attendance",
                c => new
                    {
                        id = c.Guid(nullable: false),
                        student_id = c.Guid(nullable: false),
                        subject_id = c.Guid(nullable: false),
                        count_of_misses = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.tbl_students", t => t.student_id, cascadeDelete: true)
                .ForeignKey("dbo.tbl_subjects", t => t.subject_id, cascadeDelete: true)
                .Index(t => t.student_id)
                .Index(t => t.subject_id);
            
            CreateTable(
                "dbo.tbl_students",
                c => new
                    {
                        student_id = c.Guid(nullable: false),
                        student_name = c.String(nullable: false, maxLength: 100),
                        student_address = c.String(nullable: false, maxLength: 100),
                        student_group_number = c.String(nullable: false, maxLength: 6),
                        student_course_number = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.student_id);
            
            CreateTable(
                "dbo.tbl_subjects",
                c => new
                    {
                        subject_id = c.Guid(nullable: false),
                        subject_name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.subject_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tbl_student_subject_attendance", "subject_id", "dbo.tbl_subjects");
            DropForeignKey("dbo.tbl_student_subject_attendance", "student_id", "dbo.tbl_students");
            DropIndex("dbo.tbl_student_subject_attendance", new[] { "subject_id" });
            DropIndex("dbo.tbl_student_subject_attendance", new[] { "student_id" });
            DropTable("dbo.tbl_subjects");
            DropTable("dbo.tbl_students");
            DropTable("dbo.tbl_student_subject_attendance");
        }
    }
}
