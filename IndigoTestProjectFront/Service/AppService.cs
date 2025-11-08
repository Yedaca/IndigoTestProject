using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace IndigoTestProjectFront.Service
{
    
    public class AppService
    {
        private readonly HttpClient _Client;
        public AppService()
        {
            _Client = new HttpClient { BaseAddress = new Uri("https://localhost:7006/") };
        }

        public async Task<T?> GetAsyncByCode<T>(string endpoint, string Code)
        {
            var response = await _Client.GetAsync($"{endpoint}{Code}");
            var content = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode)
                throw new Exception($"Error {response.StatusCode}: {content}");

            return JsonSerializer.Deserialize<T>(content, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });
        }

        public async Task<T?> GetAsync<T>(string endpoint)
        {
            var response = await _Client.GetAsync(endpoint);
            var content = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode)
                throw new Exception($"Error {response.StatusCode}: {content}");

            return JsonSerializer.Deserialize<T>(content, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });
        }

        public async Task<T?> PostAsync<T>(string endpoint, object data)
        {
            var json = JsonSerializer.Serialize(data);
            var response = await _Client.PostAsync(endpoint, new StringContent(json, Encoding.UTF8, "application/json"));
            var content = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode)
                throw new Exception($"Error {response.StatusCode}: {content}");

            return JsonSerializer.Deserialize<T>(content, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });
        }

        public async Task<T?> PutAsync<T>(string endpoint, object data)
        {
            var json = JsonSerializer.Serialize(data);
            var response = await _Client.PutAsync(endpoint, new StringContent(json, Encoding.UTF8, "application/json"));
            var content = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode)
                throw new Exception($"Error {response.StatusCode}: {content}");

            return JsonSerializer.Deserialize<T>(content, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });
        }

        public async Task<T?> DeleteAsync<T>(string endpoint, int Id)
        {
            var response = await _Client.DeleteAsync($"{endpoint}{Id}");
            var content = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode)
                throw new Exception($"Error {response.StatusCode}: {content}");

            return JsonSerializer.Deserialize<T>(content, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });
        }
    }
}
