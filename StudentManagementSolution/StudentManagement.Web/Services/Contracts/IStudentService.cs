﻿using StudentManagement.Models.Dtos;

namespace StudentManagement.Web.Services.Contracts
{
    public interface IStudentService
    {
        Task<IEnumerable<StudentDto>> GetStudentsDetailsInfo();

        Task<StudentDto> GetStudentDetailsById(string studentId);

        Task<StudentMarkUpdateDto> GetStudentMarksById(int? studentId);
    }
}
