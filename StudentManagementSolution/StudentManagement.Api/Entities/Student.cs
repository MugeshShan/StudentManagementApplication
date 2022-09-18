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

        public string FathersName { get; set; } = null!;

        public string Address { get; set; } = null!;

        public string Email { get; set; } = null!;

        public string PhoneNumber { get; set; } = null!;
    }
}
