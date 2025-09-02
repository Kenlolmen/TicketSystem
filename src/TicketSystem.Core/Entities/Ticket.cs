using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicketSystem.src.TicketSystem.Core.ValueObjects;

namespace TicketSystem.src.TicketSystem.Core.Entities
{
    public class Ticket
    {
        Guid Id { get; set; }
        Initials Initials { get; set; } 
        Fullname Fullname { get; set; }
        DateTime CreatedAt { get; set; }
        Status Status { get; set; }
        string Title { get; set; } 
        string Description { get; set; } 
        string Email { get; set; } 
        
    }
}