namespace LexiconLMSBlazor.Client.Services
{
    public interface IXDtoClient
    {
        Task<T?> GetAsync<T>(int id, string route);
        Task<T?> GetAsync<T>(string route);
        Task<T?> PostAsync<T>(T dto, string route);
        Task<bool> PutAsync<T>(int id, T dto, string route);
        Task<bool> RemAsync(int id, string route);
    }
}