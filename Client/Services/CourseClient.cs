using System.Net.Http.Json;
using System.Reflection.PortableExecutable;

namespace LexiconLMSBlazor.Client.Services
{
    public class CourseClient
    {
        private readonly HttpClient httpClient;

        public CourseClient(HttpClient httpClient)
        {
            this.httpClient = httpClient;
            this.httpClient.BaseAddress = new Uri("https://localhost:nnnn"); // Lokal databas.            
        }

        public async Task<IEnumerable<Machine>?> GetAsync()
        {
            var response = await httpClient.GetFromJsonAsync<IEnumerable<LMS>>("api/LMS");
            return response;
        }

        public async Task<Machine?> GetAsync(string id)
        {
            return await httpClient.GetFromJsonAsync<LMS>($"api/LMS/{id}");
        }

        public async Task<Machine?> PostAsync(LMS lms)
        {
            var response = await httpClient.PostAsJsonAsync("api/LMS", lms);
            return response.IsSuccessStatusCode ? await response.Content.ReadFromJsonAsync<LMS>() : null;
        }

        public async Task<bool> RemoveAsync(string id)
        {
            return (await httpClient.DeleteAsync($"api/LMS/{id}")).IsSuccessStatusCode;
        }

        public async Task<bool> PutAsync(string id, LMS lms)
        {
            return (await httpClient.PutAsJsonAsync($"api/LMS/{id}", lms)).IsSuccessStatusCode;
        }
    }
}
