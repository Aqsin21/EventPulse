using EventPulse.BLL.Services.Abstract;
using EventPulse.DAL.DataContext.Entities;
using Microsoft.AspNetCore.Mvc;
namespace EventPulse.API.Controllers.Admin
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _service;

        public CategoryController(ICategoryService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            var categories =await _service.GetAllAsync();
            return Ok(categories);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var category = await _service.GetByIdAsync(id);
            if(category== null) return NotFound();
            return Ok(category);

        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync([FromBody] Category category)
        {
            if (await _service.ExistsAsync(c => c.Name == category.Name))
                return BadRequest("This Category is Exist");
            await _service.CreateAsync(category);
            return CreatedAtAction(nameof(GetById), new { id = category.Id }, category);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAsync(int id, [FromBody] Category category)
        {
            var existCategory = await _service.GetByIdAsync(id);
            if (existCategory == null) return NotFound();

            existCategory.Name=category.Name;
            existCategory.Description=category.Description;
            await _service.UpdateAsync(existCategory);
            return Ok(existCategory);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            var category = _service.GetByIdAsync(id);
            if (category==null) return NotFound();
            await _service.DeleteAsync(id);
            return NoContent();

        }
    }
}
