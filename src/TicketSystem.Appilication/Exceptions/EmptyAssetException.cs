using TicketSystem.src.TicketSystem.Core.ValueObjects;

namespace TicketSystem.src.TicketSystem.Appilication.Exceptions
{
    public sealed class EmptyAssetException : Exception
    {
        public EmptyAssetException(ServiceTag serviceTag) : base($"Asset {serviceTag} not found. ") { }
    }

}