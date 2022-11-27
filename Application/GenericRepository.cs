using Domain;
using Services;

namespace Application
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseClass
    {
        public Task<IReadOnlyList<T>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<T> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}