using LexiconLMSBlazor.Shared.Dtos;

namespace LexiconLMSBlazor.Client.Services
{
    public interface ICourseDtoClient
    {
        Task<IEnumerable<CourseDto>?> GetAsync();
        Task<CourseDto?> GetAsync(string id);
        Task<CourseDto?> PostAsync(CourseDto courseDto);
        Task<bool> PutAsync(string id, CourseDto courseDto);
        Task<bool> RemoveAsync(string id);
    }
}