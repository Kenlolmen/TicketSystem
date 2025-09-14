using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicketSystem.Appilication.Abstractions;


namespace TicketSystem.Appilication.Commands
{
    public sealed record DeleteTicket(Guid TicketId): ICommand;
}