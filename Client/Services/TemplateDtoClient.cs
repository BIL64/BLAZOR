using LexiconLMSBlazor.Shared.Dtos;
using System.Net.Http.Json;

namespace LexiconLMSBlazor.Client.Services
{
    public class TemplateDtoClient
    {
        private readonly HttpClient httpClient;

        public TemplateDtoClient(HttpClient httpClient)
        {
            this.httpClient = httpClient;
            this.httpClient.BaseAddress = new Uri("https://localhost:nnnn"); // Lokal databas.            
        }

        public async Task<IEnumerable<TemplateDto>?> GetAsync()
        {
            var response = await httpClient.GetFromJsonAsync<IEnumerable<TemplateDto>>("api/x");
            return response;
        }

        public async Task<TemplateDto?> GetAsync(string id)
        {
            return await httpClient.GetFromJsonAsync<TemplateDto>($"api/x/{id}");
        }

        public async Task<TemplateDto?> PostAsync(TemplateDto courseDto)
        {
            var response = await httpClient.PostAsJsonAsync("api/x", courseDto);
            return response.IsSuccessStatusCode ? await response.Content.ReadFromJsonAsync<TemplateDto>() : null;
        }

        public async Task<bool> RemoveAsync(string id)
        {
            return (await httpClient.DeleteAsync($"api/x/{id}")).IsSuccessStatusCode;
        }

        public async Task<bool> PutAsync(string id, TemplateDto courseDto)
        {
            return (await httpClient.PutAsJsonAsync($"api/x/{id}", courseDto)).IsSuccessStatusCode;
        }

        // Dimitri tipsar:
        //var res = await GetAsync2<ModuleDto>("api/modules/1");
        //var res2 = await GetAsync2<IEnumerable<ModuleDto>>("api/modules");
        //
        //public async Task<T> GetAsync2<T>(string route)
        //{
        //    var response = await httpClient.GetFromJsonAsync<T>(route);
        //    return response;
        //}
    }
}
