namespace EventPulse.DAL.DataContext.Entities
{
    public class Event:BaseEntity
    {
        public required string Name { get; set; }
        public required string Description { get; set; }
        public required DateTime StartDate { get; set; }
        public required DateTime EndDate { get; set; }
        public int VenueId { get; set; }
        public Venue? Venue { get; set; }
        public int CategoryId { get; set; }
        public Category? Category { get; set; }


    }
}
