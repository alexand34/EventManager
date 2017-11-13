using System;
using EventManager.Core.StaticMembers;

namespace EventManager.Core.Entities
{
    public class User : BaseEntity
    {
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Roles Role { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
