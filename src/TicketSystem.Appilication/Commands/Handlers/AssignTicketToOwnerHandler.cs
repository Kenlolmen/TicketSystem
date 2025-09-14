using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicketSystem.Appilication.Abstractions;
using TicketSystem.Appilication.Exceptions;
using TicketSystem.Core.Entities;

namespace TicketSystem.Appilication.Commands.Handlers
{
    public sealed class AssignTicketToOwnerHandler : ICommandHandler<AssignTicketToOwner>
    {
        private readonly ITicketRepository _ticketRepository;
        private readonly IUserRepository _userRepository;

        public async Task HandleAsync(AssignTicketToOwner command)
        {
            var ticket = await GetTicketAsync(command.TicketId);
            if (ticket is null)
                throw new TicketNotFoundException();    
        }

        private async Task<User> GetUserAsync(Initials Initials)
            => (await _userRepository.GetAllAsync())
                .SingleOrDefault(x => x.User.Any(n => n.Initials == Initials));

        private async Task<Ticket> GetTicketAsync(Guid ticketId)
            => (await _ticketRepository.GetAllAsync())
                .SingleOrDefault(x => x.Ticket.Any(n => n.Id == ticketId));
    }
}