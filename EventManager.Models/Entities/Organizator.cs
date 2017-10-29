using System;
using System.Collections.Generic;

namespace EventManager.Models.Entities
{
    public class Organizator : User
    {
        public int EventsOrganized { get; set; }
        public int EventsComing { get; set; }
        public bool OrganizatorAccoutPaid { get; set; }
        public double Rating { get; set; }
        public List<User> UsersBlocked { get; set; }
    }
}
