using TicketSystem.src.TicketSystem.Appilication.Abstractions;
using TicketSystem.src.TicketSystem.Appilication.DTOs;

namespace TicketSystem.src.TicketSystem.Appilication.Queries
{
    public class GetAsset : IQuery<AssetDto>
    {
        public string ServiceTag { get; set; }
    }
}