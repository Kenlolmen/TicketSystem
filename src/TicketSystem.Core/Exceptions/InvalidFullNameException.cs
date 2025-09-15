namespace TicketSystem.src.TicketSystem.Core.Exceptions
{
    public class InvalidFullNameException : Exception
    {
        public string Fullname { get; }
        public InvalidFullNameException(string fullname) : base($"Full name: {fullname} is invalid."){}
        
    }
}