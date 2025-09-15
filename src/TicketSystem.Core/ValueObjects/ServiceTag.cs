using TicketSystem.src.TicketSystem.Core.Exceptions;

namespace TicketSystem.src.TicketSystem.Core.ValueObjects
{
    public sealed record ServiceTag
    {
        public string Value { get; }
        public ServiceTag(string value)
        {
            if (string.IsNullOrWhiteSpace(value) || value.Length < 4 || value.Length > 6)
            {
                throw new Exceptions.InvalidServiceTagException();
            }

            Value = value;
        }
    }
}