using Microsoft.EntityFrameworkCore;
using StudentManagement.Api.Data;
using StudentManagement.Api.Entities;
using StudentManagement.Api.Repositories.Contract;

namespace StudentManagement.Api.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private readonly StudentDbContext studentDbContext;

        public StudentRepository(StudentDbContext _studentDbContext)
        {
            studentDbContext = _studentDbContext;
        }
        public async Task<IEnumerable<Student>> GetAllStudentsInfo()
        {
            var students = await studentDbContext.Students.ToListAsync();
                                    
            return students;
        }

        public async Task<Student> GetStudentDetailsById(string studentId)
        {
            var student = await studentDbContext.Students.SingleOrDefaultAsync(x=> x.RollNumber == studentId);

            return student;
        }

        public async Task<StudentMarks> GetStudentMarksById(string studentId)
        {
            var student = await studentDbContext.StudentMarks.SingleOrDefaultAsync(x => x.RollNumber == studentId);

            return student;
        }
    }
}
