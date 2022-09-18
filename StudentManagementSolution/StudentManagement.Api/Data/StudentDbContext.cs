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
                RollNumber = "11A123",
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
                RollNumber = "11A124",
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
                RollNumber = "11A125",
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

            modelBuilder.Entity<StudentMarks>().HasData(new StudentMarks
            {
                RollNumber = "11A123",
                Id = 1,
                English = 74,
                Maths = 98,
                Science = 99,
                Social = 85,
                TotalMarks = 445
            });
            modelBuilder.Entity<StudentMarks>().HasData(new StudentMarks
            {
                RollNumber = "11A124",
                Id=2,
                Tamil = 89,
                English = 74,
                Maths = 98,
                Science = 99,
                Social = 85,
                TotalMarks = 445
            });

            modelBuilder.Entity<StudentMarks>().HasData(new StudentMarks
            {
                RollNumber = "11A125",
                Id=3,
                Tamil = 89,
                English = 74,
                Maths = 98,
                Science = 99,
                Social = 85,
                TotalMarks = 445
            });
        }

        public DbSet<Student> Students { get; set; }

        public DbSet<StudentMarks> StudentMarks { get; set;}
    }
}
