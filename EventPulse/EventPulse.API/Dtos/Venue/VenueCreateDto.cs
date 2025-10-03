using System.ComponentModel.DataAnnotations;

namespace EventPulse.API.Dtos.Venue
{
    public class VenueCreateDto
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

        [Required]
        public IFormFile ImageFile { get; set; }
    }
}
