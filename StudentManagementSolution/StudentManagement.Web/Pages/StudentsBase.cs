using Microsoft.AspNetCore.Components;
using StudentManagement.Models.Dtos;
using StudentManagement.Web.Services.Contracts;

namespace StudentManagement.Web.Pages
{
    public class StudentsBase : ComponentBase
    {

        [Inject]
        public IStudentService StudentService { get; set; }

        public IEnumerable<StudentDto>? Students { get; set; }

        public string? ErrorMessage { get; set; }

        protected override async Task OnInitializedAsync()
        {
            try
            {
                Students = await StudentService.GetStudentsDetailsInfo();
            }

            catch (Exception ex)
            {
                ErrorMessage = ex.Message;

            }
        }
    }
}
