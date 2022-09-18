using StudentManagement.Api.Entities;

namespace StudentManagement.Api.Repositories.Contract
{
    public interface IStudentRepository
    {
        Task<IEnumerable<Student>> GetAllStudentsInfo();

        Task<Student> GetStudentDetailsById(string studentId);

        Task<StudentMarks> GetStudentMarksById(string studentId);
    }
}
