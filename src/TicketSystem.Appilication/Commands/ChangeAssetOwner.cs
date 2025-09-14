using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicketSystem.Appilication.Abstractions;

namespace TicketSystem.Appilication.Commands
{
    public sealed record ChangeAssetOwner(ServiceTag ServiceTag, Initials Initials) : ICommand;
}