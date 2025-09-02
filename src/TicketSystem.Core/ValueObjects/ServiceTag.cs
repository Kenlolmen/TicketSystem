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
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Service tag cannot be null or empty.", nameof(value));
            }

            Value = value;
        }
    }
}