using Blazored.LocalStorage;
using Microsoft.JSInterop;
using System.Net.Http.Json;

namespace LexiconLMSBlazor.Client.Services
{
    public class XDtoClient : IXDtoClient
    {
        private readonly HttpClient _httpClient;
        private readonly ILocalStorageService _localStorageService;
        private readonly IJSRuntime _js;

        public XDtoClient(HttpClient httpClient, ILocalStorageService localStorageService, IJSRuntime jS)
        {
            _httpClient = httpClient;
            _localStorageService = localStorageService; // LocalStorage.
            httpClient.BaseAddress = new Uri("https://localhost:7044"); // Lokal databas.            
            _js = jS;
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

        public async Task<bool> PutAsync<T>(int id, T dto, string route)
        {
            return (await _httpClient.PutAsJsonAsync($"{route}/{id}", dto)).IsSuccessStatusCode;
        }

        public async Task<T?> PostAsync<T>(T dto, string route)
        {
            var response = await _httpClient.PostAsJsonAsync(route, dto);
            return response.IsSuccessStatusCode ? await response.Content.ReadFromJsonAsync<T>() : default;
        }

        public async Task<bool> RemAsync(int id, string route)
        {
            return (await _httpClient.DeleteAsync($"{route}/{id}")).IsSuccessStatusCode;
        }

        public async Task<string?> GetStorage<T>(string name) // LocalStorage Get.
        {
            return await _localStorageService.GetItemAsync<string>(name);
        }

        public async Task SetStorage(string name, string value) // LocalStorage Set.
        {
            await _localStorageService.SetItemAsync(name, value);
        }

        public async Task<HttpResponseMessage> PostFile(MultipartFormDataContent content) // Sparar namnkrypterade filer på servern.
        {
            var response = await _httpClient.PostAsync($"{_httpClient.BaseAddress}Filesave", content);
            return response;
        }

        public async Task OpenFile(int ix, string filename) // Öppnar en fil med hjälp av ett javascript.
        {
            await _js.InvokeVoidAsync("triggerFileDownload", filename, $"{_httpClient.BaseAddress}Documents/{ix.ToString() + filename}");
        }

        public async Task<T?> ExistFile<T>(string filename, string route) // Kollar om filens filnamn redan existerar.
        {
            var response = await _httpClient.GetFromJsonAsync<T>($"{route}/{filename}");
            return response;
        }

        public async Task<bool> DeleteFile(string filename) // Tar bort en namnkrypterad fil på servern.
        {
            return (await _httpClient.DeleteAsync($"Filesave/{filename}")).IsSuccessStatusCode;
        }

        public string GetFilepath() // Returnerar sökvägen till dokumentmappen.
        {
            return $"{_httpClient.BaseAddress}Documents/";
        }

        public async Task<WindowDimension> GetWindow() // Returnerar skärmstorlek med hjälp av ett javascript och en klass.
        {
            var dimension = await _js.InvokeAsync<WindowDimension>("getWindowDimensions");
            return dimension;
        }

        public async Task ChangeClass(string id, string newclassname) // Byter css-klass på ett id-försett objekt.
        {
            await _js.InvokeVoidAsync("swapDocClass", id, newclassname);
        }

        public async Task Scroll2View(string id) // Skrollar till en id-tag med hjälp av ett javascript.
        {
            await _js.InvokeVoidAsync("scrollIntoView", id);
        }
    }

    public class WindowDimension
    {
        public int Width { get; set; }
        public int Height { get; set; }
    }

    // Dimitris Björlingh:
    //var res = await GetAsync2<ModuleDto>("api/modules/1");
    //var res2 = await GetAsync2<IEnumerable<ModuleDto>>("api/modules");
    //
    //public async Task<T> GetAsync2<T>(string route)
    //{
    //    var response = await httpClient.GetFromJsonAsync<T>(route);
    //    return response;
    //}
}
