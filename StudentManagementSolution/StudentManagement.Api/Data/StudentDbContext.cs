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
                RollNumber = "8A001",
                Name = "Adhi",
                Class = "VIII",
                Dob = "11-09-2009",
                FathersName = "Madhan",
                Address = "Chidambaram",
                Email = "adhi.madhan@gmail.com",
                PhoneNumber = "9952744908"
            });
            modelBuilder.Entity<Student>().HasData(new Student
            {
                RollNumber = "8A002",
                Name = "Balu",
                Class = "VIII",
                Dob = "05-09-2009",
                FathersName = "Dhileep",
                Address = "Cuddalore",
                Email = "balu.dhileep@gmail.com",
                PhoneNumber = "9488940491"
            });
            modelBuilder.Entity<Student>().HasData(new Student
            {
                RollNumber = "8A003",
                Name = "Chinthan",
                Class = "VIII",
                Dob = "17-12-2009",
                FathersName = "Vikram",
                Address = "Pondicherry",
                Email = "chinthan.vikram@gmail.com",
                PhoneNumber = "8610681447"
            });
            modelBuilder.Entity<Student>().HasData(new Student
            {
                RollNumber = "8A004",
                Name = "Dinesh",
                Class = "VIII",
                Dob = "17-11-2009",
                FathersName = "Aravind",
                Address = "Chidambaram",
                Email = "dinesh.aravind@gmail.com",
                PhoneNumber = "9443877178"
            });
            modelBuilder.Entity<Student>().HasData(new Student
            {
                RollNumber = "8A005",
                Name = "Ezhil",
                Class = "VIII",
                Dob = "17-02-2010",
                FathersName = "Mohan",
                Address = "Chidambaram",
                Email = "ezhil.mohan@gmail.com",
                PhoneNumber = "9488046422"
            });

            modelBuilder.Entity<StudentMarks>().HasData(new StudentMarks
            {
                RollNumber = "8A001",
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
                RollNumber = "8A002",
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
                RollNumber = "8A003",
                Id=3,
                Tamil = 85,
                English = 85,
                Maths = 85,
                Science = 85,
                Social = 85,
                TotalMarks = 425
            });
            modelBuilder.Entity<StudentMarks>().HasData(new StudentMarks
            {
                RollNumber = "8A004",
                Id = 4,
                Tamil = 75,
                English = 75,
                Maths = 75,
                Science = 75,
                Social = 75,
                TotalMarks = 400
            });
            modelBuilder.Entity<StudentMarks>().HasData(new StudentMarks
            {
                RollNumber = "8A005",
                Id = 5,
                Tamil = 70,
                English = 70,
                Maths = 70,
                Science = 70,
                Social = 70,
                TotalMarks = 375
            });
        }

        public DbSet<Student> Students { get; set; }

        public DbSet<StudentMarks> StudentMarks { get; set;}
    }
}
