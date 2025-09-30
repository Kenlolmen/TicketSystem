using TicketSystem.src.TicketSystem.Core.ValueObjects;
using TicketSystem.src.TicketSystem.Core.Entities;

namespace TicketSystem.src.TicketSystem.Core.Repositories
{
    public interface IAssetRepository
    {
        Task<Asset> GetByServiceTagAsync(ServiceTag serviceTag);
        Task<Asset> GetAllAsync();
        Task AddAsync(Asset asset);
        Task UpdateAsync(Asset asset);
        Task DeleteAsync(Asset asset);

    }
}