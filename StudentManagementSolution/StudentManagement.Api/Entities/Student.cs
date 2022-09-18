using System.ComponentModel.DataAnnotations;

namespace StudentManagement.Api.Entities
{
    public class Student
    {
        [Key]
        public int RollNumber { get; set; }
        public string Name { get; set; } = null!;
        public string Class { get; set; } = null!;
        public string Dob { get; set; } = null!;
        public int Tamil { get; set; }
        public int English { get; set; }
        public int Maths { get; set; }
        public int Science { get; set; }
        public int Social { get; set; }
        public int TotalMarks { get; set; }
    }
}
