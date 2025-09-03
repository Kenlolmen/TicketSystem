using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicketSystem.src.TicketSystem.Core.ValueObjects
{
    public sealed record ServiceTag
    {
        public string Value { get; }
        public ServiceTag(string value)
        {
            if (string.IsNullOrWhiteSpace(value) || value.Length < 4 || value.Length > 6)
            {
                throw new InvalidServiceTagException();
            }

            Value = value;
        }
    }
}