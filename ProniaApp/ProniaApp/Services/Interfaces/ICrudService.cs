using ProniaApp.Models;

namespace ProniaApp.Services.Interfaces
{
    public interface ICrudService<T>where T : BaseEntity
    {
        Task CreateAsync(T entity);
        void Delete(T entity);
        Task SaveAsync();
        void Edit(T entity);
    }
}
