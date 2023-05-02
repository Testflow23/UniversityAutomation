using Microsoft.EntityFrameworkCore;
using UniversityManagement.Models.Courses;
using UniversityManagement.Models.Login;
using UniversityManagement.Models.Register;
using UniversityManagement.Models.Subjects;

namespace UniversityManagement.Models
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext(DbContextOptions options) : base(options)
        {



        }
        public DbSet<Student> Student { get; set; }
        public DbSet<College> College { get; set; }
        public DbSet<Teacher> Teacher { get; set; }
        public DbSet<All_Courses> All_Courses { get; set; }
        public DbSet<All_Subjects> All_Subjects { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<College>().HasNoKey();

            modelBuilder.Entity<All_Courses>().HasNoKey();
            modelBuilder.Entity<All_Subjects>().HasNoKey();
           
        }
    }
}
