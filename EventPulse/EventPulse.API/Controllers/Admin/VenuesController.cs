using EventPulse.BLL.Services.Abstract;
using EventPulse.DAL.DataContext.Entities;
using EventPulse.DAL.Repositories.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace EventPulse.API.Controllers.Admin
{
    [Route("api/admin/[controller]")]
    public class VenuesController : ControllerBase
    {
        private readonly IVenueService _service;

        public VenuesController(IVenueService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var venues = await _service.GetAllAsync();
            return Ok(venues);
        }

        [HttpGet("{id}")]
        public  async Task<IActionResult> GetById(int id)
        {
            var venue = await _service.GetByIdAsync(id);
            if (venue == null) return NotFound();
            return Ok(venue);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync([FromBody] Venue venue)
        {
            if(await _service.ExistsAsync(v=>v.Name == venue.Name))
                return BadRequest("This venue is Already Exist");
            await _service.CreateAsync(venue);
            return CreatedAtAction(nameof(GetById), new {id = venue.Id} , venue);
            
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAsync(int id ,[FromBody] Venue venue)
        {
            var existingVenue = await _service.GetByIdAsync(id);
            if (existingVenue == null) return NotFound();

            existingVenue.Name = venue.Name;
            existingVenue.Location = venue.Location;
            existingVenue.Description = venue.Description;
            existingVenue.Capacity = venue.Capacity;
            existingVenue.ImageUrl = venue.ImageUrl;

            await _service.UpdateAsync(existingVenue);
            return Ok(existingVenue);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            var venue= await _service.GetByIdAsync(id);
            if (venue == null) return NotFound();
            await _service.DeleteAsync(id);
            return NoContent();

        }

    }

}