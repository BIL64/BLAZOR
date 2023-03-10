using LexiconLMSBlazor.Shared.Dtos;
using System.Net.Http.Headers;
using System.Net.Http.Json;

namespace LexiconLMSBlazor.Client.Services
{
    public class AppUserDtoClient : IAppUserDtoClient
    {
        private readonly HttpClient httpClient;

        public AppUserDtoClient(HttpClient httpClient)
        {
            this.httpClient = httpClient;
            this.httpClient.BaseAddress = new Uri("https://localhost:7044"); // Lokal databas.
            this.httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<IEnumerable<AppUserDto>?> GetAsync()
        {
            var response = await httpClient.GetFromJsonAsync<List<AppUserDto>>("api/AppUser");
            return response;
        }
    }
}
