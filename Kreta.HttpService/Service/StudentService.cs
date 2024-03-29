﻿using Kreta.Shared.Dtos;
using Kreta.Shared.Models;
using Kreta.Shared.Responses;


namespace Kreta.HttpService.Service
{
    public class StudentService : IStudentService
    {
        private readonly HttpClient? _httpClient;

        public StudentService(IHttpClientFactory? httpClientFactory)
        {
            if (httpClientFactory is not null)
            {
                _httpClient = httpClientFactory.CreateClient("KretaApi");
            }
        }

        public async Task<List<Student>> SelectAllStudent()
        {
            return new List<Student>();
        }

        public async Task<ControllerResponse> Update(StudentDto studentDto)
        {
            ControllerResponse defaultResponse = new();
            return defaultResponse;
        }

        public async Task<ControllerResponse> DeleteAsync(Guid id)
        {
            ControllerResponse defaultResponse = new();
            return defaultResponse;
        }


        public async Task<ControllerResponse> InsertAsync(Student student)
        {
            ControllerResponse defaultResponse = new();         
            return defaultResponse;
        }


    }
}
