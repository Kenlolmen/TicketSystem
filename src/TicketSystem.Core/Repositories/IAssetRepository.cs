using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicketSystem.Core.Repositories
{
    public interface IAssetRepository
    {
        Task<Asset?> GetByServiceTagAsync(string serviceTag);
        Task AddAsync(Asset asset);
        Task UpdateAsync(Asset asset);
        Task DeleteAsync(Asset asset);

    }
}