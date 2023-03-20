using LexiconLMSBlazor.Shared.Dtos;
using System.Net.Http.Json;

namespace LexiconLMSBlazor.Client.Services
{
    public class XDtoClient : IXDtoClient
    {
        private readonly HttpClient httpClient;

        public XDtoClient(HttpClient httpClient)
        {
            this.httpClient = httpClient;
            this.httpClient.BaseAddress = new Uri("https://localhost:7044"); // Lokal databas.            
        }

        public async Task<T?> GetAsync<T>(string route)
        {
            var response = await httpClient.GetFromJsonAsync<T>(route);
            return response;
        }

        public async Task<T?> GetAsync<T>(int id, string route)
        {
            var response = await httpClient.GetFromJsonAsync<T>($"{route}/{id}");
            return response;
        }

        public async Task<T?> PostAsync<T>(T dto, string route)
        {
            var response = await httpClient.PostAsJsonAsync(route, dto);
            return response.IsSuccessStatusCode ? await response.Content.ReadFromJsonAsync<T>() : default(T);
        }

        public async Task<bool> RemAsync(int id, string route)
        {
            return (await httpClient.DeleteAsync($"{route}/{id}")).IsSuccessStatusCode;
        }

        public async Task<bool> PutAsync<T>(int id, T dto, string route)
        {
            return (await httpClient.PutAsJsonAsync($"{route}/{id}", dto)).IsSuccessStatusCode;
        }
    }
}
