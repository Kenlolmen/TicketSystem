using TicketSystem.src.TicketSystem.Core.Exceptions;

namespace TicketSystem.src.TicketSystem.Core.ValueObjects
{
    public sealed record Model
    {
        public string Value { get; }

        public Model(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new Exceptions.EmptyModelException();
            }

            Value = value;
        }
    }
}