using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicketSystem.Core.Exceptions
{
    public class InvalidServiceTagException
    {
        public InvalidServiceTagException() : base("Service tag cannot be null or empty. Must have at least from 4-6 characters") { }
    }
}