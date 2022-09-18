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
                RollNumber = "8A123",
                Name = "Mugesh",
                Class = "VIII",
                Dob = "11-09-2002"
            });
            modelBuilder.Entity<Student>().HasData(new Student
            {
                RollNumber = "9A124",
                Name = "Prakash",
                Class = "IX",
                Dob = "05-09-2001"
            });
            modelBuilder.Entity<Student>().HasData(new Student
            {
                RollNumber = "11A125",
                Name = "Sagar",
                Class = "XI",
                Dob = "17-12-2000"
            });

            modelBuilder.Entity<StudentMarks>().HasData(new StudentMarks
            {
                RollNumber = "8A123",
                Id = 1,
                Tamil = 95,
                English = 95,
                Maths = 95,
                Science = 95,
                Social = 95,
                TotalMarks = 475
            });
            modelBuilder.Entity<StudentMarks>().HasData(new StudentMarks
            {
                RollNumber = "9A124",
                Id=2,
                Tamil = 90,
                English = 90,
                Maths = 90,
                Science = 90,
                Social = 90,
                TotalMarks = 450
            });

            modelBuilder.Entity<StudentMarks>().HasData(new StudentMarks
            {
                RollNumber = "11A125",
                Id=3,
                Tamil = 85,
                English = 85,
                Maths = 85,
                Science = 85,
                Social = 85,
                TotalMarks = 425
            });
        }

        public DbSet<Student> Students { get; set; }

        public DbSet<StudentMarks> StudentMarks { get; set;}
    }
}
