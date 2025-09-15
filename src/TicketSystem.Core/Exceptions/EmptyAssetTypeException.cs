namespace TicketSystem.src.TicketSystem.Core.Exceptions
{
    public class EmptyAssetTypeException : Exception
    {
        public EmptyAssetTypeException() : base("Asset type cannot be empty.") { }
    }
}