using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicketSystem.Core.Exceptions
{
    public class EmptyAssetTypeException : Exception
    {
        public EmptyAssetTypeException() : base("Asset type cannot be empty.") { }
    }
}