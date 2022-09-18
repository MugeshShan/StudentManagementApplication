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

        public Task<Student> GetStudentDetailsById(int? studentId)
        {
            throw new NotImplementedException();
        }

        public Task<Student> GetStudentMarksById(int? studentId)
        {
            throw new NotImplementedException();
        }
    }
}
