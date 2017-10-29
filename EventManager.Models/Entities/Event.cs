using System.Collections.Generic;

namespace EventManager.Models.Entities
{
    public class Event : BaseEntity
    {
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string FullDescription { get; set; }
        public decimal Price { get; set; }
        public int MaximumGuestsAllowed { get; set; }
        public string Address { get; set; }
        public List<Organizator> Organizators { get; set; }
        public List<Member> Members { get; set; }
    }
}
