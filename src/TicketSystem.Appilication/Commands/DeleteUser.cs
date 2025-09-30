using TicketSystem.src.TicketSystem.Appilication.Abstractions;
using TicketSystem.src.TicketSystem.Core.ValueObjects;

namespace TicketSystem.src.TicketSystem.Appilication.Commands
{
    public sealed record DeleteUser(Initials Initials): ICommand;
}