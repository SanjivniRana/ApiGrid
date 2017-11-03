namespace ApiGrid.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class GridApiTbl : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.StudentDetails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PhoneNo = c.Int(nullable: false),
                        Address = c.String(),
                        FatherName = c.String(),
                        MotherName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        SId = c.Int(nullable: false, identity: true),
                        SName = c.String(),
                        RollNo = c.Int(nullable: false),
                        Course = c.String(),
                        Department = c.String(),
                        StudentDetail_Id = c.Int(),
                    })
                .PrimaryKey(t => t.SId)
                .ForeignKey("dbo.StudentDetails", t => t.StudentDetail_Id)
                .Index(t => t.StudentDetail_Id);
            
            CreateTable(
                "dbo.StudentViewModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        student_SId = c.Int(),
                        studentdetail_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Students", t => t.student_SId)
                .ForeignKey("dbo.StudentDetails", t => t.studentdetail_Id)
                .Index(t => t.student_SId)
                .Index(t => t.studentdetail_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.StudentViewModels", "studentdetail_Id", "dbo.StudentDetails");
            DropForeignKey("dbo.StudentViewModels", "student_SId", "dbo.Students");
            DropForeignKey("dbo.Students", "StudentDetail_Id", "dbo.StudentDetails");
            DropIndex("dbo.StudentViewModels", new[] { "studentdetail_Id" });
            DropIndex("dbo.StudentViewModels", new[] { "student_SId" });
            DropIndex("dbo.Students", new[] { "StudentDetail_Id" });
            DropTable("dbo.StudentViewModels");
            DropTable("dbo.Students");
            DropTable("dbo.StudentDetails");
        }
    }
}
