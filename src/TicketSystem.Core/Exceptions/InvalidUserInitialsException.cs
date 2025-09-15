namespace TicketSystem.src.TicketSystem.Core.Exceptions
{
    public class InvalidUserInitialsException : Exception
    {
        public InvalidUserInitialsException() : base("Invalid user initials. User initials must be at least 4 characters long and contain only letters.")
        {
        }
    }
}