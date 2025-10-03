using EventPulse.BLL.Services.Abstract;
using EventPulse.DAL.DataContext.Entities;
using Microsoft.AspNetCore.Mvc;
namespace EventPulse.API.Controllers.Admin
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketTypeController : ControllerBase
    {
        private readonly ITicketTypeService _service;

        public TicketTypeController(ITicketTypeService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            var tickettypes = await _service.GetAllAsync();
            return Ok(tickettypes);

        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var tickettype = await _service.GetByIdAsync(id);
            if (tickettype == null) return NotFound();
            return Ok(tickettype);

        }
        [HttpPost]
        public async Task<IActionResult> CreateAsync([FromBody] TicketType ticketType )
        {
            if(await _service.ExistsAsync(t=>t.Name == ticketType.Name))
            return BadRequest("This TicketType Exist");
            await _service.CreateAsync(ticketType);
            return Ok(ticketType);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAsync(int id , [FromBody] TicketType ticketType)
        {
            var existTicketType = await _service.GetByIdAsync(id);
            if(existTicketType == null) return NotFound();
            existTicketType.Name = ticketType.Name;
            
            await _service.UpdateAsync(existTicketType);
            return Ok(existTicketType);
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            var ticketType = _service.GetByIdAsync(id);
            if (ticketType == null) return NotFound();
            await _service.DeleteAsync(id);
            return NoContent();

        }
    }
}