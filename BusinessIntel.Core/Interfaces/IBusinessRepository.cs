using BusinessIntel.Core.Models;
using BusinessIntel.Core.Results;

namespace BusinessIntel.Core.Interfaces;

public interface IBusinessRepository
{
    Task<RepositoryResult> AddAsync(Business business);

    Task<Business?> GetByIdAsync(Guid id);

    Task<List<Business>> GetAllAsync();

    Task<RepositoryResult> DeleteAsync(Guid id);

    Task<RepositoryResult> UpdateAsync(Business business);
}
