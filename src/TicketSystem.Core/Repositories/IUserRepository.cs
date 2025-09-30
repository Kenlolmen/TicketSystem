using TicketSystem.src.TicketSystem.Core.ValueObjects;
using TicketSystem.src.TicketSystem.Core.Entities;

namespace TicketSystem.src.TicketSystem.Core.Repositories
{
    public interface IUserRepository
    {
        Task<User> GetByInitialsAsync(Initials initials);
        Task<User> GetAllAsync();
        Task AddAsync(User user);
        Task DeleteAsync(User user);
    }
}