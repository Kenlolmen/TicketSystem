using TicketSystem.src.TicketSystem.Appilication.Abstractions;
using TicketSystem.src.TicketSystem.Appilication.DTOs;

namespace TicketSystem.src.TicketSystem.Appilication.Queries
{
    public class GetTicket : IQuery<TicketDto>
    {
        public int Id { get; set; }
    }
}