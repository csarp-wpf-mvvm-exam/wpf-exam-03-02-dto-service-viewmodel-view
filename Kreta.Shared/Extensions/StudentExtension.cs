﻿using Kreta.Shared.Dtos;
using Kreta.Shared.Models;

namespace Kreta.Shared.Extensions
{
    public static class StudentExtension
    {
        public static StudentDto ToStudentDto(this Student student)
        {
            return new StudentDto
            {
                Id=student.Id,
            };
        }

        public static Student ToStudent(this StudentDto studentdto) 
        {
            return new Student
            {
                Id = studentdto.Id,
            };
        }
    }

}
