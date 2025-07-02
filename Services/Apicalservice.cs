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


namespace adapter.Services
{
    public class ApiResponse<T>
    {
        public List<T> data { get; set; }
    }

    public class Apical
    {
        private readonly HttpClient _httpClient;
        private const string ApiBaseUrl = "https://admissionss.sdbin.org/api/";
        private readonly StudentInsertService _insertService;

        public Apical(HttpClient httpClient, StudentInsertService insertService)
        {
            _httpClient = httpClient;
            _httpClient.BaseAddress = new Uri(ApiBaseUrl);
            _httpClient.DefaultRequestHeaders.Add("Authorization", "$2y$12$bKcFO4vwXx9WRZbQipPuY.MSkHOD0X4jMeqoOQKkcXCjwXzhCexyz");
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            _insertService = insertService;
        }

        public async Task<List<ApplicationInfo>> GetAllApplicationsAsync()
        //public async Task<IActionResult> GetAllApplicationsAsync()
        {

            try
            {
                var response = await _httpClient.GetAsync("applications");
                response.EnsureSuccessStatusCode();

                var content = await response.Content.ReadAsStringAsync();

                //Deserialize into wrapper class
                var result = JsonConvert.DeserializeObject<ApiResponse<ApplicationInfo>>(content);
                //List <string> failedentries = new();
                var fetched_data = result?.data ?? new List<ApplicationInfo>();

                foreach (var entry in fetched_data)
                {
                    try
                    {
                        Console.WriteLine(entry.name +" : "+entry.application_id);
                        if (entry.payment_gateway_status == null && entry.payment_info is not null && entry.payment_info.status=="success")
                        {
                            Console.WriteLine($"PAYMENT UNMATCHED FOR {entry.name}");
                            continue;
                        }
                        int user_id = await _insertService.InsertApplication(entry);
                        //user_details
                        if (user_id == 0) 
                        {
                            Console.WriteLine($"Skipping entry: insert failed for {entry.name}");
                            continue;
                        }
                        entry.recieve_id = user_id;//await _insertService.GetRecieveId(entry);
                        await _insertService.InsertUserAccountService(entry);
                        Console.WriteLine(entry.course.name);
                        await _insertService.InsertMarksFromApplication(entry);
                        await _insertService.InsertStudentAddress(entry);
                        await _insertService.InsertUploadedFiles(entry);
                        await _insertService.InsertAdmIssuedApplication(entry);
                        //String od_id = await _insertService.InsertForderInfo25(entry);
                        //await _insertService.InsertAdmSelectionProcess(entry);
                        await _insertService.InsertForderInfo25(entry);
                        //entry.od_id = od_id;
                        /*if (int.Parse(entry.od_id) == 0)
                        {
                            Console.WriteLine($"Skipping entry: Order Creation failed for {entry.name}");
                            continue;
                        }*/

                        if (entry.payment_info != null)
                        //if (entry.payment_gateway_status != null && entry.payment_gateway_status?.ToLower() == "success")
                        {
                            //await _insertService.InsertForderInfo25(entry);     //payment_info my not be null for droppped or cancelled transaction
                            if (entry.payment_info.status.ToLower() == "success")
                            {
                                //ensures only the success transaction
                                await _insertService.InsertAFebTfResponse25(entry);
                                int transid = await _insertService.InsertFeeTransactionAsync(entry);
                                entry.Transaction_id = transid;
                                await _insertService.InsertFeeCollectionAsync(entry);
                            }

                        }
                        else { }
                        await _insertService.InsertFeeStudentAccountAsync(entry);
                        await _insertService.InsertAdmSelectionProcess(entry);
                        /*if (entry.interview_msg != null && entry.interview_msg.ToLower() == "yes")
                        {
                            await _insertService.InsertAdmSelectionProcess(entry);
                        } */
                    }
                    catch (Exception ex)
                    {
                        //failedentries.Add(entry.application_id);
                        Console.WriteLine("Failed for : " + entry.application_id);
                        Console.WriteLine($"Failed for: {entry.application_id}, Error: {ex.Message}");
                        continue;
                    }



                    /*Console.WriteLine($"Applicant: {entry.name}, Email: {entry.email}");

                    if (entry.registration != null)
                        Console.WriteLine($"  Registered Campus: {entry.registration.campus_info?.name}");

                    if (entry.dept != null)
                        Console.WriteLine($"  Department: {entry.dept.name}");

                    if (entry.course != null)
                        Console.WriteLine($"  Course: {entry.course.name}");

                    if (entry.religion_info != null)
                        Console.WriteLine($"  Religion: {entry.religion_info.name}");
                    
                    Console.WriteLine($"  Religion: {entry.registration.country_info?.name}");
                    Console.WriteLine($"  Religion: {entry.registration.campus_info?.name}"); */

                    //return new List<ApplicationInfo>();
                }
                Console.WriteLine($"{fetched_data.Count} Applications Processes");
                return fetched_data;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[ERROR] Failed to fetch applications: {ex.Message}");

                return new List<ApplicationInfo>();
            }
        }
    }
}
