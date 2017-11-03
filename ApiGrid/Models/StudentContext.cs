using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ApiGrid.Models
{
    public class StudentContext : DbContext
    {
        public StudentContext() : base("name=StudentString")
        {

        }
        public DbSet<Student> Students { get; set; }
        public DbSet<StudentDetail> StudentDetails { get; set; }
        public DbSet<StudentViewModel> StudentViewModels { get; set; }

        /*protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Student>()
            //    .HasRequired(c => c.StudentDetail)
            //    .WithRequiredPrincipal(c => c.Student);


            // Configure StudentId as FK for StudentAddress
            modelBuilder.Entity<Student>()
                        .HasRequired(s => s.StudentDetail)
                        .WithRequiredPrincipal(ad => ad.Student);


            base.OnModelCreating(modelBuilder);
        }*/
    }
}