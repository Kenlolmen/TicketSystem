using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicketSystem.Core.Repositories
{
    public interface ITicketRepository
    {
        Task<Ticket?> GetByIdAsync(Guid id);
        Task<IEnumerable<Ticket>> GetByStatus(Status status);
        Task AddAsync(Ticket ticket);
        Task UpdateAsync(Ticket ticket);
        Task DeleteAsync(Guid id);

    }
}