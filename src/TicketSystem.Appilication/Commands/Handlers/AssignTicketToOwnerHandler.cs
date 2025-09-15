using TicketSystem.src.TicketSystem.Appilication.Abstractions;
using TicketSystem.src.TicketSystem.Appilication.Exceptions;
using TicketSystem.src.TicketSystem.Core.Entities;
using TicketSystem.src.TicketSystem.Core.Repositories;
using TicketSystem.src.TicketSystem.Core.ValueObjects;

namespace TicketSystem.src.TicketSystem.Appilication.Commands.Handlers
{
    public sealed class AssignTicketToOwnerHandler : ICommandHandler<AssignTicketToOwner>
    {
        private readonly ITicketRepository _ticketRepository;
        private readonly IUserRepository _userRepository;
        public AssignTicketToOwnerHandler(ITicketRepository ticketRepository, IUserRepository userRepository)
        {
            _ticketRepository = ticketRepository;
            _userRepository = userRepository;
        }


        public async Task HandleAsync(AssignTicketToOwner command)
        {
            var ticket = await GetTicketAsync(command.TicketId);
            if (ticket is null)
                throw new TicketNotFoundException();
        }

        private async Task<User> GetUserAsync(Initials initials)
        {
            var user = await _userRepository.GetByInitialsAsync(initials);
            return user;
        }

        private async Task<Ticket> GetTicketAsync(Guid ticketId)
        {
            var ticket = await _ticketRepository.GetByIdAsync(ticketId);
            return ticket;
        }


    }
}