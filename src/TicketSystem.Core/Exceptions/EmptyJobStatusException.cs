namespace TicketSystem.src.TicketSystem.Core.Exceptions
{
    public class EmptyJobStatusException : Exception
    {
        public EmptyJobStatusException() : base("Job status cannot be empty.") { }
    }
}