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

        public async Task<IEnumerable<Temp1Dto>?> GetAsync()
        {
            var response = await httpClient.GetFromJsonAsync<IEnumerable<Temp1Dto>>("api/CourseDto");
            return response;
        }

        public async Task<Temp1Dto?> GetAsync(string id)
        {
            return await httpClient.GetFromJsonAsync<Temp1Dto>($"api/CourseDto/{id}");
        }

        public async Task<Temp1Dto?> PostAsync(Temp1Dto courseDto)
        {
            var response = await httpClient.PostAsJsonAsync("api/CourseDto", courseDto);
            return response.IsSuccessStatusCode ? await response.Content.ReadFromJsonAsync<Temp1Dto>() : null;
        }

        public async Task<bool> RemoveAsync(string id)
        {
            return (await httpClient.DeleteAsync($"api/CourseDto/{id}")).IsSuccessStatusCode;
        }

        public async Task<bool> PutAsync(string id, Temp1Dto courseDto)
        {
            return (await httpClient.PutAsJsonAsync($"api/CourseDto/{id}", courseDto)).IsSuccessStatusCode;
        }
    }
}
