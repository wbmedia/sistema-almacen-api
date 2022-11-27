using Domain;
using Services;

namespace Application
{
    public class ActiveRepository : IActiveRepository
    {
        public Task<Active> GetActiveByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<Active>> GetAllActiveAsync()
        {
            throw new NotImplementedException();
        }
    }
}
