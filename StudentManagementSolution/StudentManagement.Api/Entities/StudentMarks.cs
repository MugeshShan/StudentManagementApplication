using System.ComponentModel.DataAnnotations.Schema;

namespace StudentManagement.Api.Entities
{
    public class StudentMarks
    {
        public int Id { get; set; }
        [ForeignKey("RollNumber")]
        public string? RollNumber { get; set; }
        public int Tamil { get; set; }
        public int English { get; set; }
        public int Maths { get; set; }
        public int Science { get; set; }
        public int Social { get; set; }
        public int TotalMarks { get; set; }
    }
}
