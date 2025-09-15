namespace TicketSystem.src.TicketSystem.Core.Exceptions{
    public class EmptyModelException : Exception
    {
        public EmptyModelException() : base("Model cannot be empty.") { }
    }
}