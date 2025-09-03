using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicketSystem.Core.Repositories
{
    public interface IUserRepository
    {
        Task<User?> GetByInitialsAsync(string initials);
        Task AddAsync(User user);
        Task DeleteAsync(string initials);
    }
}