using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicketSystem.src.TicketSystem.Core.Exceptions
{
    public class EmptyJobStatusException : Exception
    {
        public EmptyJobStatusException() : base("Job status cannot be empty.") { }
    }
}