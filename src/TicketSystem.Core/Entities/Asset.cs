using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicketSystem.src.TicketSystem.Core.ValueObjects;

namespace TicketSystem.src.TicketSystem.Core.Entities
{
    public class Asset
    {
        ServiceTag ServiceTag { get; set; }
        Model Model { get; set; }
        AssetType Type { get; set; }
    }
}