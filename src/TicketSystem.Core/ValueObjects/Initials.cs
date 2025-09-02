using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicketSystem.src.TicketSystem.Core.ValueObjects
{
    public sealed record Initials
    {
        public string Value { get; }

        private Initials(string value)
        {
            if(string.IsNullOrWhiteSpace(value) || value.Length < 4 || !value.All(char.IsLetter))
            {
                throw new Exceptions.InvalidUserInitialsException();
            }
            Value = value;
        }

    }
}