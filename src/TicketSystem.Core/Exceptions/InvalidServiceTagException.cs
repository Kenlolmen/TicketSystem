namespace TicketSystem.src.TicketSystem.Core.Exceptions
{
    public class InvalidServiceTagException : Exception
    {
        public InvalidServiceTagException() : base("Service tag cannot be null or empty. Must have at least from 4-6 characters") { }
    }
}