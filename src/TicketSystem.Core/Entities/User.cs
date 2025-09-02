using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using TicketSystem.src.TicketSystem.Core.ValueObjects;

namespace TicketSystem.src.TicketSystem.Core.Entities
{
    public class User
    {
        Initials Initials { get; set; }
        Fullname Fullname { get; set; }
        JobTitle JobTitle { get; set; }
        string Email { get; set; }

        public User(Initials initials, Fullname fullname, JobTitle jobTitle, string email)
        {
            Initials = initials;
            Fullname = fullname;
            JobTitle = jobTitle;
            Email = email;
        }

    }
}