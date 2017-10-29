using System;
using EventManager.Models.StaticMembers;

namespace EventManager.Models.Entities
{
    public class User : BaseEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public bool EmailConfirmed { get; set; }
        public bool PhoneConfirmed { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public DateTime DateofBirth { get; set; }
        public AccoutStatus UserStatus { get; set; }
    }
}
