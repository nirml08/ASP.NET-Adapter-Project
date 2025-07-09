using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json;
using adapter.Model.apicaldata;
using adapter.Model.classmodel;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.AspNetCore.Mvc;
using adapter.Services;
using static System.Net.Mime.MediaTypeNames;
using System.Text;


namespace adapter.Services
{


    public class ApicalById
    {
        private readonly HttpClient _httpClient;
        private const string ApiBaseUrl = "https://admissionss.sdbin.or/api/";  //change in the api for fetch by id
        private readonly StudentInsertService _insertService;

        public ApicalById(HttpClient httpClient, StudentInsertService insertService)
        {
            _httpClient = httpClient;
            _httpClient.BaseAddress = new Uri(ApiBaseUrl);
            _httpClient.DefaultRequestHeaders.Add("Authorization", "$2y$12$bKcFO4vwXx9WRZbQipPuY.MSkHOD0X4jMeqoOQKkcXCjwXzhCeYMK");
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            _insertService = insertService;
        }

        public async Task<List<ApplicationInfo>> UpdateApplicationById(int applicationId)
        //public async Task<IActionResult> GetAllApplicationsAsync()
        {
            try
            {
                var payload = new { id = applicationId }; // Adjust key to match your API's expected request body

                var content = new StringContent(
                    JsonConvert.SerializeObject(payload),
                    Encoding.UTF8,
                    "application/json"
                );

                var response = await _httpClient.PostAsync("applications/getbyid", content); // Adjust endpoint
                response.EnsureSuccessStatusCode();

                var json = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<ApiResponse<ApplicationInfo>>(json);

                return result?.data ?? new List<ApplicationInfo>();
            }
            catch (Exception ex)
            {
                // Handle error (log or return empty list)
                Console.WriteLine($"Error: {ex.Message}");
                return new List<ApplicationInfo>();
            }

        }
    }
}
