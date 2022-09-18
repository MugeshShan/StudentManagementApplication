using System.ComponentModel.DataAnnotations;

namespace StudentManagement.Api.Entities
{
    public class Student
    {
        [Key]
        public string? RollNumber { get; set; }
        public string Name { get; set; } = null!;
        public string Class { get; set; } = null!;
        public string Dob { get; set; } = null!;
    }
}
