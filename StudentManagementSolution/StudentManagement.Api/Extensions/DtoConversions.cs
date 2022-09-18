using StudentManagement.Api.Entities;
using StudentManagement.Models.Dtos;

namespace StudentManagement.Api.Extensions
{
    public static class DtoConversions
    {
        public static IEnumerable<StudentDto> ConvertToDto(this IEnumerable<Student> students)
        {
            return (from student in students
                        select new StudentDto
                        {
                            RollNumber = student.RollNumber,
                            Name = student.Name,
                            Class = student.Class,
                            Dob = student.Dob
                        }
                   );
        }

        public static StudentDto ConvertToDto(this Student student)
        {
            return new StudentDto
            {
                RollNumber = student.RollNumber,
                Name = student.Name,
                Class = student.Class,
                Dob = student.Dob
            };
        }

        public static StudentMarkUpdateDto ConvertToDto(this StudentMarks student)
        {
            return new StudentMarkUpdateDto
            {
                RollNumber = student.RollNumber,
                Tamil = student.Tamil,
                English = student.English,
                Maths = student.Maths,
                Science = student.Science,
                Social = student.Social,
                TotalMarks = student.TotalMarks
            };
        }
    }
}
