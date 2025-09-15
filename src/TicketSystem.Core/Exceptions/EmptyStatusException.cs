namespace TicketSystem.src.TicketSystem.Core.Exceptions
{
    public class EmptyStatusException : Exception
    {
        public EmptyStatusException() : base("Status cannot be empty. Please provide a valid status.")
        {
        }
    }
}