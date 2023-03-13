using LexiconLMSBlazor.Shared.Dtos;

namespace LexiconLMSBlazor.Client.Services
{
    public interface IAppUserDtoClient
    {
        Task<IEnumerable<AppUserDto>?> GetAsync();
        Task<bool> PreAsync(string id, int prefix);
        Task<bool> RemAsync(string id);
    }
}