using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicketSystem.src.TicketSystem.Core.ValueObjects
{
    public sealed record AssetType
    {
        public string Value { get; }

        public AssetType(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new Exceptions.EmptyAssetTypeException();
            }

            Value = value;
        }

        public static readonly AssetType Laptop = new("Laptop");
        public static readonly AssetType Monitor = new("Monitor");
        public static readonly AssetType Phone = new("Smartphone");
        public static readonly AssetType Printer = new("Printer");
    }
}