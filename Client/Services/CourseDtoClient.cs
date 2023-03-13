using LexiconLMSBlazor.Shared.Dtos;
using System.Net.Http.Headers;
using System.Net.Http.Json;

namespace LexiconLMSBlazor.Client.Services
{
    public class CourseDtoClient : ICourseDtoClient
    {
        private readonly HttpClient httpClient;

        public CourseDtoClient(HttpClient httpClient)
        {
            this.httpClient = httpClient;
            this.httpClient.BaseAddress = new Uri("https://localhost:7044"); // Lokal databas.
            this.httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<IEnumerable<CourseDto>?> GetAsync()
        {
            var response = await httpClient.GetFromJsonAsync<IEnumerable<CourseDto>>("api/Course");
            return response;
        }

        public async Task<CourseDto?> GetAsync(string id)
        {
            return await httpClient.GetFromJsonAsync<CourseDto>($"api/Course/{id}");
        }

        public async Task<CourseDto?> PostAsync(CourseDto courseDto)
        {
            var response = await httpClient.PostAsJsonAsync("api/Course", courseDto);
            return response.IsSuccessStatusCode ? await response.Content.ReadFromJsonAsync<CourseDto>() : null;
        }

        public async Task<bool> RemoveAsync(string id)
        {
            return (await httpClient.DeleteAsync($"api/Course/{id}")).IsSuccessStatusCode;
        }

        public async Task<bool> PutAsync(string id, CourseDto courseDto)
        {
            return (await httpClient.PutAsJsonAsync($"api/Course/{id}", courseDto)).IsSuccessStatusCode;
        }
    }
}
