using System.ComponentModel.DataAnnotations;

namespace EventPulse.API.Dtos.Venue
{
    public class VenueUpdateDto
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string Location { get; set; }

        [Required]
        [Range(1, int.MaxValue)]
        public int Capacity { get; set; }
        public IFormFile? ImageFile { get; set; }
    }
}
