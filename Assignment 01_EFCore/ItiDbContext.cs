using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment_01_EFCore.Models;
using Microsoft.EntityFrameworkCore;

namespace Assignment_01_EFCore
{
    public class ItiDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-DIRMGF2;database=itiDb;trusted_connection=true;TrustServerCertificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Stud_Course>()
                .HasKey(sc => new { sc.stud_ID, sc.Course_ID });


            modelBuilder.Entity<Course_Inst>()
                .HasKey(sc => new { sc.inst_ID, sc.Course_ID });
        }

       
        public DbSet<Student> Student { get; set; }

        public DbSet<Course> Course { get; set; }

        public DbSet<Stud_Course> StudCourse { get; set; }

        public DbSet<Department> Department { get; set; }

        public DbSet<Topic> Topic { get; set; }

        public DbSet<Instructor> Instructor { get; set; }


        public DbSet<Course_Inst> Course_Inst { get; set; }


    }
}
