using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentManagement.Api.Entities;
using StudentManagement.Api.Extensions;
using StudentManagement.Api.Repositories.Contract;
using StudentManagement.Models.Dtos;

namespace StudentManagement.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentRepository studentRepository;
        public StudentController(IStudentRepository _studentRepository)
        {
            this.studentRepository = _studentRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<StudentDto>>> GetStudentsInfo()
        {
            try
            {
                var students = await this.studentRepository.GetAllStudentsInfo();

                if(students == null)
                {
                    return NotFound();
                }
                else
                {
                    var studentDtos = students.ConvertToDto();
                    return Ok(studentDtos);
                }
            }
            catch(Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                               "Error retrieving data from the database");
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<StudentDto>> GetStudentInfoById(string id)
        {
            try
            {
                var student = await this.studentRepository.GetStudentDetailsById(id);

                if(student == null)
                {
                    return BadRequest();
                }
                else
                {
                    var studentDto = student.ConvertToDto();

                    return Ok(studentDto);
                }
            }
            catch(Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                                "Error retrieving data from the database");
            }
        }

        [HttpGet("{id}/marks")]
        public async Task<ActionResult<StudentMarkDto>> GetStudentMarksById(string id)
        {
            try
            {
                var student = await this.studentRepository.GetStudentMarksById(id);

                if (student == null)
                {
                    return BadRequest();
                }
                else
                {
                    var studentDto = student.ConvertToDto();

                    return Ok(studentDto);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                                "Error retrieving data from the database");
            }
        }
    }
}
