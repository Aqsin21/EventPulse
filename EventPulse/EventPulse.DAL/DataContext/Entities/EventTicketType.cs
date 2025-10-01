namespace EventPulse.DAL.DataContext.Entities
{
    public class EventTicketType:BaseEntity
    {
        public int EventId { get; set; }
        public Event? Event { get; set; }
        public int TicketTypeId { get; set; }
        public TicketType? TicketType { get; set; }
        public required int Quantity { get; set; }
        public required decimal Price { get; set; }


    }
}
