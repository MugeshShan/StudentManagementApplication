using StudentManagement.Models.Dtos;
using StudentManagement.Web.Services.Contracts;
using System.Net.Http.Json;

namespace StudentManagement.Web.Services
{
    public class StudentService : IStudentService
    {
        private readonly HttpClient httpClient;

        public StudentService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public Task<StudentDto> GetStudentDetailsById(string studentId)
        {
            throw new NotImplementedException();
        }

        public Task<StudentMarkUpdateDto> GetStudentMarksById(int? studentId)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<StudentDto>> GetStudentsDetailsInfo()
        {
            try
            {
                //var response = await this.httpClient.GetAsync("api/Students");

                //if (response.IsSuccessStatusCode)
                //{
                //    if (response.StatusCode == System.Net.HttpStatusCode.NoContent)
                //    {
                //        return Enumerable.Empty<StudentDto>();
                //    }
                //    return await response.Content.ReadFromJsonAsync<IEnumerable<StudentDto>>();
                //}
                //else
                //{
                //    var message = await response.Content.ReadAsStringAsync();
                //    throw new Exception($"Http status code: {response.StatusCode} message: {message}");
                //}

                var students = await this.httpClient.GetFromJsonAsync<IEnumerable<StudentDto>>("api/Student");

                return students;
            }
            catch(Exception ex)
            {
                throw;
            }
        }
    }
}
