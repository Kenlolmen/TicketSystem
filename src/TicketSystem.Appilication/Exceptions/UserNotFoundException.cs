using TicketSystem.src.TicketSystem.Core.ValueObjects;

namespace TicketSystem.src.TicketSystem.Appilication.Exceptions
{
    public class UserNotFoundException : Exception
    {
        public UserNotFoundException(Initials initials) : base($"User {initials} not found. ") { }
    }
}