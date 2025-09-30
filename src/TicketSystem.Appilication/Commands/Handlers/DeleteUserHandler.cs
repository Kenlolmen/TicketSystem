using TicketSystem.src.TicketSystem.Appilication.Abstractions;
using TicketSystem.src.TicketSystem.Appilication.Exceptions;
using TicketSystem.src.TicketSystem.Core.Entities;
using TicketSystem.src.TicketSystem.Core.Repositories;
using TicketSystem.src.TicketSystem.Core.ValueObjects;

namespace TicketSystem.src.TicketSystem.Appilication.Commands.Handlers
{
    public class DeleteUserHandler : ICommandHandler<DeleteUser>
    {
        private readonly IUserRepository _userRepository;
        
        public DeleteUserHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task HandleAsync(DeleteUser command)
        {
            var user = await _userRepository.GetByInitialsAsync(command.Initials);


            if (user is null)
            {
                throw new UserNotFoundException(command.Initials);
            }

            await _userRepository.DeleteAsync(user);
        }
    }
}
