namespace EventPulse.DAL.DataContext.Entities
{
    public class Venue:BaseEntity
    {
        public required string Name { get; set; } 
        public required string Description { get; set; }
        public required string Location { get; set; }
        public required int Capacity { get; set; }
        public string? ImageUrl { get; set; }
    }
}
