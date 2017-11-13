using System;

namespace EventManager.Core.Entities
{
    public class Event : BaseEntity
    {
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public int ParticipantsAllowed { get; set; }
        public int ParticipantsNow { get; set; }
        public User Organizator { get; set; }
        public bool IsRegistrationOpen { get; set; }
        public string Description { get; set; }
    }
}
