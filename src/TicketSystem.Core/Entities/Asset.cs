using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicketSystem.src.TicketSystem.Core.ValueObjects;

namespace TicketSystem.src.TicketSystem.Core.Entities
{
    public class Asset
    {

        ServiceTag ServiceTag { get; set; }
        Initials OwnerInitials { get; set; }
        Model Model { get; set; }
        AssetType Type { get; set; }

        public Asset(ServiceTag serviceTag,Initials ownerInitials, Model model, AssetType type)
        {
            ServiceTag = serviceTag;
            OwnerInitials = ownerInitials;
            Model = model;
            Type = type; 
        }
    }
}