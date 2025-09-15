using TicketSystem.src.TicketSystem.Core.ValueObjects;
using TicketSystem.src.TicketSystem.Core.Entities;

namespace TicketSystem.src.TicketSystem.Core.Repositories
{
    public interface ITicketRepository
    {
        Task<Ticket> GetByIdAsync(Guid id);
        Task<Ticket> GetAllAsync();
        Task<IEnumerable<Ticket>> GetByStatus(Status status);
        Task AddAsync(Ticket ticket);
        Task UpdateAsync(Ticket ticket);
        Task DeleteAsync(Guid id);

    }
}