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
    }
}
