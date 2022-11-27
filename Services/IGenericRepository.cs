using Domain;

namespace Services
{
    public interface IGenericRepository<T> where T : BaseClass
    {
        Task<T> GetByIdAsync(Guid id);

        Task<IReadOnlyList<T>> GetAllAsync();
    }
}