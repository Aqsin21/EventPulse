namespace EventPulse.DAL.DataContext.Entities
{
    public class Organizer:BaseEntity
    {
        public required string Name { get; set; } 
        public string? Description { get; set; }
        public string? LogoUrl { get; set; }

        public string UserId { get; set; } = null!;
        public AppUser User { get; set; } = null!;

        public ICollection<Event> Events { get; set; } = new List<Event>();
    }
}
