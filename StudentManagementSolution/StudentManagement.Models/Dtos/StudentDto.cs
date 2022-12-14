using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Models.Dtos
{
    public class StudentDto
    {
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
