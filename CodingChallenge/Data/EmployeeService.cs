using CodingChallenge.Domain.Models.Models;
using Microsoft.AspNetCore.Components;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data
{
    public class EmployeeService : IEmployeeService
    {
        string baseUrl = "https://localhost:44357/";


        public async Task<Employee[]> GetEmployeesAsync()
        {
            HttpClient http = new HttpClient();
            var json = await http.GetStringAsync($"{baseUrl}api/employees");
            return JsonConvert.DeserializeObject<Employee[]>(json);
        }

        public async Task<Employee> GetEmployeesByIdAsync(string id)
        {
            HttpClient http = new HttpClient();
            var json = await http.GetStringAsync($"{baseUrl}api/employees/{id}");
            return JsonConvert.DeserializeObject<Employee>(json);
        }

        public async Task<HttpResponseMessage> InsertEmployeeAsync(Employee employee)
        {
            var client = new HttpClient();
            return await client.PostAsync($"{baseUrl}api/employees", getStringContentFromObject(employee));
        }

        public async Task<HttpResponseMessage> UpdateEmployeeAsync(string id, Employee employee)
        {
            var client = new HttpClient();
            return await client.PutAsync($"{baseUrl}api/employees/{id}", getStringContentFromObject(employee));
        }

        public async Task<HttpResponseMessage> DeleteEmployeeAsync(string id)
        {
            var client = new HttpClient();
            return await client.DeleteAsync($"{baseUrl}api/employees/{id}");
        }

        private StringContent getStringContentFromObject(object obj)
        {
            var serialized = JsonConvert.SerializeObject(obj);
            var stringContent = new StringContent(serialized, Encoding.UTF8, "application/json");
            return stringContent;
        }
    }
}
