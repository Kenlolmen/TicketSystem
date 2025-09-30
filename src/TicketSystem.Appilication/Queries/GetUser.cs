using TicketSystem.src.TicketSystem.Appilication.Abstractions;
using TicketSystem.src.TicketSystem.Appilication.DTOs;

namespace TicketSystem.src.TicketSystem.Appilication.Queries
{
    public class GetUser : IQuery<UserDto>
    {
        public string Initials { get; set; }
    }
}