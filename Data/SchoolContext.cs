//tinfo200:[2021-03-13-<hbathal>-dykstra1]-- Create SchoolContext class in created Data folder
//this creates the database to store all courses, enrollments, and students

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContosoUniversity.Models;
using Microsoft.EntityFrameworkCore;


namespace ContosoUniversity.Data
{
    public class SchoolContext : DbContext
    {
        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options)
        {//tinfo200:[2021-03-13-<hbathal>-dykstra1]-- do nothing constructor 
        }

        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Student> Students { get; set; }

        //tinfo200:[2021-03-13-<hbathal>-dykstra1]--Assigning the names to the entity table
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>().ToTable("Course");
            modelBuilder.Entity<Enrollment>().ToTable("Enrollment");
            modelBuilder.Entity<Student>().ToTable("Student");
        }
    }
}