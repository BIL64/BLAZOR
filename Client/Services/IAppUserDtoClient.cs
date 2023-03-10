using LexiconLMSBlazor.Shared.Dtos;

namespace LexiconLMSBlazor.Client.Services
{
    public interface IAppUserDtoClient
    {
        Task<IEnumerable<AppUserDto>?> GetAsync();
    }
}