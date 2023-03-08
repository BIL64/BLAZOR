using LexiconLMSBlazor.Shared.Dtos;
using System.Net.Http.Json;
using System.Reflection.PortableExecutable;

namespace LexiconLMSBlazor.Client.Services
{
    public class CourseDtoClient
    {
        private readonly HttpClient httpClient;

        public CourseDtoClient(HttpClient httpClient)
        {
            this.httpClient = httpClient;
            this.httpClient.BaseAddress = new Uri("https://localhost:nnnn"); // Lokal databas.            
        }

        public async Task<IEnumerable<CourseDto>?> GetAsync()
        {
            var response = await httpClient.GetFromJsonAsync<IEnumerable<CourseDto>>("api/CourseDto");
            return response;
        }

        public async Task<CourseDto?> GetAsync(string id)
        {
            return await httpClient.GetFromJsonAsync<CourseDto>($"api/CourseDto/{id}");
        }

        public async Task<CourseDto?> PostAsync(CourseDto courseDto)
        {
            var response = await httpClient.PostAsJsonAsync("api/CourseDto", courseDto);
            return response.IsSuccessStatusCode ? await response.Content.ReadFromJsonAsync<CourseDto>() : null;
        }

        public async Task<bool> RemoveAsync(string id)
        {
            return (await httpClient.DeleteAsync($"api/CourseDto/{id}")).IsSuccessStatusCode;
        }

        public async Task<bool> PutAsync(string id, CourseDto courseDto)
        {
            return (await httpClient.PutAsJsonAsync($"api/CourseDto/{id}", courseDto)).IsSuccessStatusCode;
        }
    }
}
