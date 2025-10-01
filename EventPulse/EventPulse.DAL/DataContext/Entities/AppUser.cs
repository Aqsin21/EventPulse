using Microsoft.AspNetCore.Identity;
namespace EventPulse.DAL.DataContext.Entities
{
    public class AppUser:IdentityUser
    {
        public required string FullName { get; set; }
        public OrganizerApplication? OrganizerApplication { get; set; } 
        public Organizer? Organizer { get; set; } 
    }
}
