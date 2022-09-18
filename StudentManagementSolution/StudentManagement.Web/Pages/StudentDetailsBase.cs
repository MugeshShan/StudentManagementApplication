using Microsoft.AspNetCore.Components;
using StudentManagement.Models.Dtos;
using StudentManagement.Web.Services.Contracts;

namespace StudentManagement.Web.Pages
{
    public class StudentDetailsBase : ComponentBase
    {
        [Parameter]
        public string Id { get; set; }

        [Inject]
        public IStudentService StudentService { get; set; }

        public StudentDto Student { get; set; }

        public string ErrorMessage { get; set; }

        protected override async Task OnInitializedAsync()
        {
            try
            {
                Student = await StudentService.GetStudentDetailsById(Id);
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
            }
        }
    }
}
