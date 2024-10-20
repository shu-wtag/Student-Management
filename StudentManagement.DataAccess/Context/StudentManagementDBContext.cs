using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using StudentManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.DataAccess.Context
{
    //StudentManagementDBContext is a giant object to search individual tables
    public class ApplicationDbContext : IdentityDbContext<AppUser>
    {
        public ApplicationDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<CourseTeach> CourseTeaches { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // overriding from the class identitydb context
            base.OnModelCreating(modelBuilder); // Ensures Identity configurations are applied



            modelBuilder.Entity<Student>().HasData
                (
                   new Student { ID = 1, Name = "A", Email = "a1@gmail.com"},
                   new Student { ID = 2, Name = "B", Email = "b2@gmail.com" },
                   new Student { ID = 3, Name = "C", Email = "c3@gmail.com" }
                );

            modelBuilder.Entity<Course>().HasData
                (
                    new Course { ID = 111, Course_Name = "A111", credits = 3},
                    new Course { ID = 112, Course_Name = "A112", credits = 2}
                );
            modelBuilder.Entity<Enrollment>(x => x.HasKey(p => new { p.StudentId, p.CourseId }));

            modelBuilder.Entity<Enrollment>()
                .HasOne(u => u.Student)
                .WithMany(u => u.Enrollments)
                .HasForeignKey(p => p.StudentId);

            modelBuilder.Entity<Enrollment>()
                .HasOne(u => u.Course)
                .WithMany(u => u.Enrollments)
                .HasForeignKey(p => p.CourseId);

            List<IdentityRole> roles = new List<IdentityRole>
            {
                new IdentityRole
                {
                    Name = "Admin",
                    NormalizedName = "ADMIN"
                },
                new IdentityRole
                {
                    Name = "User",
                    NormalizedName = "USER"
                },
            };
            modelBuilder.Entity<IdentityRole>().HasData(roles);

        }
    }

    public class ApplicationDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        public ApplicationDbContext CreateDbContext(string[] args = null)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile(@"C:\Users\Shafia Nur Huma\source\repos\Student-Management\StudentManagement\appsettings.json", optional: false, reloadOnChange: true)
                .Build();

            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));

            return new ApplicationDbContext(optionsBuilder.Options);
        }
    }



}


