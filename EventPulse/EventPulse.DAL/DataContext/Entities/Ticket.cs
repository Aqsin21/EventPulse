namespace EventPulse.DAL.DataContext.Entities
{
    public class Ticket : BaseEntity
    {
        public int EventId { get; set; }
        public Event? Event { get; set; }
        public int EventTicketTypeId { get; set; }
        public EventTicketType? EventTicketType { get; set; }
        public int AppUserId { get; set; }
        public AppUser? AppUser {get; set;}
        public  required string QRCode { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public bool IsUsed { get; set; }




    }
}
