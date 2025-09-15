using TicketSystem.src.TicketSystem.Appilication.Abstractions;


namespace TicketSystem.src.TicketSystem.Appilication.Commands
{
    public sealed record DeleteTicket(Guid TicketId): ICommand;
}