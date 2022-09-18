using Microsoft.EntityFrameworkCore;
using StudentManagement.Api.Entities;

namespace StudentManagement.Api.Data
{
    public class StudentDbContext : DbContext
    {
        public StudentDbContext(Microsoft.EntityFrameworkCore.DbContextOptions<StudentDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(Microsoft.EntityFrameworkCore.ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Student>().HasData(new Student
            {
                RollNumber = 1,
                Name = "Mugesh",
                Class = "XI",
                Dob = "11-09-1996",
                Tamil = 89,
                English = 74,
                Maths = 98,
                Science = 99,
                Social = 85,
                TotalMarks = 445
            });
            modelBuilder.Entity<Student>().HasData(new Student
            {
                RollNumber = 2,
                Name = "Prakash",
                Class = "XI",
                Dob = "11-09-1996",
                Tamil = 89,
                English = 74,
                Maths = 98,
                Science = 99,
                Social = 85,
                TotalMarks = 445
            });
            modelBuilder.Entity<Student>().HasData(new Student
            {
                RollNumber = 3,
                Name = "Sagar",
                Class = "XI",
                Dob = "11-09-1996",
                Tamil = 89,
                English = 74,
                Maths = 98,
                Science = 99,
                Social = 85,
                TotalMarks = 445
            });
        }

        public Microsoft.EntityFrameworkCore.DbSet<Student> Students { get; set; }
    }
}
