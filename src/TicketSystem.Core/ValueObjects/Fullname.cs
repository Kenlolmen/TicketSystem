using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicketSystem.src.TicketSystem.Core.ValueObjects
{
    public sealed record Fullname
    {
        public string Value { get; }

        public Fullname(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new Exceptions.InvalidFullNameException(value);
            }
            Value = value;
        }
        public static implicit operator Fullname(string value) => new Fullname(value);
        public override string ToString() => Value;
        

    }
}