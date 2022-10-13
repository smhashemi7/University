using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class UniContext : DbContext
    {
        public UniContext()
        {
            // Database.EnsureCreated();
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }

        public DbSet<StudentCourse> StudentCourse { get; set; }
        public DbSet<Teacher> Teachers { get; set; }

        //public DbSet<CourseStudent>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //base.OnConfiguring(optionsBuilder);
            var cn = "User ID=sa;password=123;Initial Catalog=Uni;Data Source=.";
            optionsBuilder.UseSqlServer(cn);

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Fluent API
            //modelBuilder.Entity<Student>().Property(s => s.FirstName).HasColumnName("Esm");
            //modelBuilder.Entity<Student>().Property(s => s.StudentCode).HasColumnName("CodeDanehjooei");

            base.OnModelCreating(modelBuilder);



            //modelBuilder.Entity<Student>()
            //    .Property(p => p.EntryDate)
            //    .HasColumnName("TarikhVorood")
            //    .HasColumnOrder(5);


            //modelBuilder.Entity<Course>().ToTable("DarsHa");

            modelBuilder.Entity<Course>()
                .Property(p => p.CourseName)
                .HasMaxLength(100);

            modelBuilder.Entity<Teacher>()
              .Property(p => p.TeachingExperience)
              .HasColumnType("tinyint");



            //modelBuilder.Entity<StudentCourse>()
            //    .HasOne(Student).wi

            modelBuilder.Entity<Student>().HasMany(s => s.Courses).WithMany(c => c.Students).UsingEntity<StudentCourse>(
                sc => sc.HasOne(e => e.Course).WithMany(),
                sc => sc.HasOne(e => e.Student).WithMany()
                );



        }

    }
}
