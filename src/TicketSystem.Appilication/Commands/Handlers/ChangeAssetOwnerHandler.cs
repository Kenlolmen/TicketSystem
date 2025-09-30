using TicketSystem.src.TicketSystem.Appilication.Abstractions;
using TicketSystem.src.TicketSystem.Appilication.Exceptions;
using TicketSystem.src.TicketSystem.Core.Entities;
using TicketSystem.src.TicketSystem.Core.Repositories;
using TicketSystem.src.TicketSystem.Core.ValueObjects;

namespace TicketSystem.src.TicketSystem.Appilication.Commands.Handlers
{
    public sealed class ChangeAssetOwnerHandler : ICommandHandler<ChangeAssetOwner>
    {
        private readonly IAssetRepository _assetRepository;
        private readonly IUserRepository _userRepository;
        public ChangeAssetOwnerHandler(IAssetRepository assetRepository, IUserRepository userRepository)
        {
            _assetRepository = assetRepository;
            _userRepository = userRepository;
        }

        public async Task HandleAsync(ChangeAssetOwner command)
        {
            var asset = _assetRepository.GetByServiceTagAsync(command.ServiceTag);
            if (asset is null)
            {
                throw new Exceptions.EmptyAssetException(command.ServiceTag);
            }
            // to be countinued

        }
        
    }
}