using TicketSystem.src.TicketSystem.Appilication.Abstractions;
using TicketSystem.src.TicketSystem.Core.ValueObjects;
using TicketSystem.src.TicketSystem.Core.Entities;

namespace TicketSystem.src.TicketSystem.Appilication.Commands
{
    public sealed record AssignTicketToOwner(Guid TicketId, Initials Initials) : ICommand;
}