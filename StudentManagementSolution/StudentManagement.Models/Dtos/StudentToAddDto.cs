using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Models.Dtos
{
    public class StudentToAddDto
    {
        public string? Name { get; set; } = null!;
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
