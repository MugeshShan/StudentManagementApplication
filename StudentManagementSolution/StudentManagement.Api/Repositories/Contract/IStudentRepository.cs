using StudentManagement.Api.Entities;

namespace StudentManagement.Api.Repositories.Contract
{
    public interface IStudentRepository
    {
        Task<IEnumerable<Student>> GetAllStudentsInfo();

        Task<Student> GetStudentDetailsById(int? studentId);

        Task<Student> GetStudentMarksById(int? studentId);
    }
}
