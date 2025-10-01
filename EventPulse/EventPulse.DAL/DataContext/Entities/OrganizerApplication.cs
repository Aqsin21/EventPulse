
namespace EventPulse.DAL.DataContext.Entities
{
    public enum OrganizerApplicationStatus
    {
        Pending,
        Approved,
        Rejected
    }
    public class OrganizerApplication:BaseEntity
    {
        public required string CompanyName { get; set; } 
        public string? Description { get; set; }
        public string? LogoUrl { get; set; }

        public required string UserId { get; set; } 
        public AppUser? User { get; set; } 
        public string? ApplicationDocumentUrl {  get; set; }

        public OrganizerApplicationStatus Status { get; set; } = OrganizerApplicationStatus.Pending;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
