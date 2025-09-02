using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicketSystem.src.TicketSystem.Core.Exceptions
{
    public class InvalidFullNameException : Exception
    {
        public string Fullname { get; }
        public InvalidFullNameException(string fullname) : base($"Full name: {fullname} is invalid."){}
        
    }
}