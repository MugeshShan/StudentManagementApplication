using Microsoft.AspNetCore.Components;
using StudentManagement.Models.Dtos;
using StudentManagement.Web.Services.Contracts;

namespace StudentManagement.Web.Pages
{
    public class StudentMarkDetailsBase : ComponentBase
    {
        [Parameter]
        public string id { get; set; }

        [Inject]
        public IStudentService StudentService { get; set; }

        public StudentMarkDto Student { get; set; }

        public string ErrorMessage { get; set; }

        protected override async Task OnInitializedAsync()
        {
            try
            {
                Student = await StudentService.GetStudentMarksById(id);
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
            }
        }
    }
}
