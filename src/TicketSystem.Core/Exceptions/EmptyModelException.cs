using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicketSystem.Core.Exceptions
{
    public class EmptyModelException
    {
        public EmptyModelException() : base("Model cannot be empty.") { }
    }
}