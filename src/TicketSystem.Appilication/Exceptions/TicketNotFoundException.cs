namespace TicketSystem.src.TicketSystem.Appilication.Exceptions
{
    public class TicketNotFoundException : Exception
    {
        public TicketNotFoundException() : base("Ticket not found.") { }
    }
}