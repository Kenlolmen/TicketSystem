using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicketSystem.src.TicketSystem.Core.Exceptions
{
    public class EmptyStatusException : Exception
    {
        public EmptyStatusException() : base("Status cannot be empty. Please provide a valid status.")
        {
        }
    }
}