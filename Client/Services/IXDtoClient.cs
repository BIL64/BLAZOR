namespace LexiconLMSBlazor.Client.Services
{
    public interface IXDtoClient
    {
        Task<T?> GetAsync<T>(int id, string route);
        Task<T?> GetAsync<T>(string route);
        Task<T> GetStorage<T>(string name);
        Task<T?> PostAsync<T>(T dto, string route);
        Task<bool> PutAsync<T>(int id, T dto, string route);
        Task<bool> RemAsync(int id, string route);
        Task SetStorage<T>(string name, string value);
    }
}