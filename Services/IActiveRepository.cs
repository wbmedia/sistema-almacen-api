using Domain;

namespace Services
{
    public interface IActiveRepository
    {
        Task<Active> GetActiveByIdAsync(Guid id);
        Task<IReadOnlyList<Active>> GetAllActiveAsync();
    }
}
