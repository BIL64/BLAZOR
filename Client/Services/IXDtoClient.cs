namespace LexiconLMSBlazor.Client.Services
{
    public interface IXDtoClient
    {
        Task ChangeClass(string id, string newclassname);
        Task<bool> DeleteFile(string filename);
        Task<T?> ExistFile<T>(string filename, string route);
        Task<T?> GetAsync<T>(int id, string route);
        Task<T?> GetAsync<T>(string route);
        string GetFilepath();
        Task<T> GetStorage<T>(string name);
        Task<WindowDimension> GetWindow();
        Task OpenFile(int ix, string filename);
        Task<T?> PostAsync<T>(T dto, string route);
        Task<HttpResponseMessage> PostFile(MultipartFormDataContent content);
        Task<bool> PutAsync<T>(int id, T dto, string route);
        Task<bool> RemAsync(int id, string route);
        Task SetStorage<T>(string name, string value);
    }
}