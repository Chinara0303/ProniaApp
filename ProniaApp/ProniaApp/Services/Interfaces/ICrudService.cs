using ProniaApp.Models;

namespace ProniaApp.Services.Interfaces
{
    public interface ICrudService<T>where T : BaseEntity
    {
        Task CreateAsync(T entity);
        Task SaveAsync();
    }
}
