namespace LexiconLMSBlazor.Client.Services
{
    public interface IXDtoClient
    {
        Task<T?> GetAsync<T>(string route);
        Task<T?> GetAsync<T>(string id, string route);
        Task<T?> PostAsync<T>(T dto, string route);
        Task<bool> PutAsync<T>(string id, T dto, string route);
        Task<bool> RemoveAsync<T>(string id, string route);
    }
}