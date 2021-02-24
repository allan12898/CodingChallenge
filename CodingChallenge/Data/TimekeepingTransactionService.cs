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
    public class TimekeepingTransactionService
    {
        string baseUrl = "https://localhost:44357/";


        public async Task<List<TimekeepingTransaction>> GetTimekeepingTransactionsAsync()
        {
            HttpClient http = new HttpClient();
            var json = await http.GetStringAsync($"{baseUrl}api/timekeepingTransactions");
            return JsonConvert.DeserializeObject<List<TimekeepingTransaction>>(json);
        }

        public async Task<TimekeepingTransaction> GetTimekeepingTransactionsByIdAsync(string id)
        {
            HttpClient http = new HttpClient();
            var json = await http.GetStringAsync($"{baseUrl}api/timekeepingTransactions/{id}");
            return JsonConvert.DeserializeObject<TimekeepingTransaction>(json);
        }


        public async Task<HttpResponseMessage> InsertTimekeepingTransactionAsync(TimekeepingTransaction timekeeping)
        {
            var client = new HttpClient();
            return await client.PostAsync($"{baseUrl}api/timekeepingTransactions", getStringContentFromObject(timekeeping));
        }


        private StringContent getStringContentFromObject(object obj)
        {
            var serialized = JsonConvert.SerializeObject(obj);
            var stringContent = new StringContent(serialized, Encoding.UTF8, "application/json");
            return stringContent;
        }
    }
}
