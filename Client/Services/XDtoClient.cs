using Blazored.LocalStorage;
using System.Net.Http.Json;

namespace LexiconLMSBlazor.Client.Services
{
    public class XDtoClient : IXDtoClient
    {
        private readonly HttpClient _httpClient;
        private readonly ILocalStorageService _localStorageService;

        public XDtoClient(HttpClient httpClient, ILocalStorageService localStorageService)
        {
            _httpClient = httpClient;
            _localStorageService = localStorageService; // LocalStorage.
            httpClient.BaseAddress = new Uri("https://localhost:7044"); // Lokal databas.            
        }

        public async Task<T?> GetAsync<T>(string route)
        {
            var response = await _httpClient.GetFromJsonAsync<T>(route);
            return response;
        }

        public async Task<T?> GetAsync<T>(int id, string route)
        {
            var response = await _httpClient.GetFromJsonAsync<T>($"{route}/{id}");
            return response;
        }

        public async Task<T?> PostAsync<T>(T dto, string route)
        {
            var response = await _httpClient.PostAsJsonAsync(route, dto);
            return response.IsSuccessStatusCode ? await response.Content.ReadFromJsonAsync<T>() : default(T);
        }

        public async Task<bool> RemAsync(int id, string route)
        {
            return (await _httpClient.DeleteAsync($"{route}/{id}")).IsSuccessStatusCode;
        }

        public async Task<bool> PutAsync<T>(int id, T dto, string route)
        {
            return (await _httpClient.PutAsJsonAsync($"{route}/{id}", dto)).IsSuccessStatusCode;
        }

        public async Task<T> GetStorage<T>(string name) // LocalStorage Get.
        {
            return await _localStorageService.GetItemAsync<T>(name);
        }
        // ex. string = await xClient.GetStorage<string>("storage_name");

        public async Task SetStorage<T>(string name, string value) // LocalStorage Set.
        {
            await _localStorageService.SetItemAsync(name, value);
        }
        // ex. await xClient.SetStorage<string>("storage_name", "d-block");
    }

    // Dimitri Björlingh:
    //var res = await GetAsync2<ModuleDto>("api/modules/1");
    //var res2 = await GetAsync2<IEnumerable<ModuleDto>>("api/modules");
    //
    //public async Task<T> GetAsync2<T>(string route)
    //{
    //    var response = await httpClient.GetFromJsonAsync<T>(route);
    //    return response;
    //}
}
