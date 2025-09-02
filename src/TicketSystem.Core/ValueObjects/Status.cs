using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicketSystem.src.TicketSystem.Core.ValueObjects
{
    public sealed record Status
    {
        public string Value { get; }

        public Status(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new Exceptions.EmptyStatusException();
            }
            
            Value = value;
        }

        public static readonly Status Open = new(nameof(Open));
        public static readonly Status InProgress = new(nameof(InProgress));
        public static readonly Status Closed = new(nameof(Closed));
        public static readonly Status Solved = new(nameof(Solved));

        

    }
}