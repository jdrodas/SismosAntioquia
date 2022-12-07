using SismosAntioquiaAPI.Models;
using SismosAntioquiaAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace SismosAntioquiaAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RegionesController : ControllerBase
    {
        private readonly RegionesService _regionesService;

        public RegionesController(RegionesService regionesService) =>
            _regionesService = regionesService;

        [HttpGet]
        public async Task<List<Region>> Get() =>
            await _regionesService.GetAsync();

        [HttpGet("{id:length(24)}")]
        public async Task<ActionResult<Region>> Get(string id)
        {
            var region = await _regionesService.GetAsync(id);

            if (region is null)
            {
                return NotFound();
            }

            return region;
        }

        [HttpPost]
        public async Task<IActionResult> Post(Region newRegion)
        {
            await _regionesService.CreateAsync(newRegion);

            return CreatedAtAction(nameof(Get), new { id = newRegion.Id }, newRegion);
        }

        [HttpPut("{id:length(24)}")]
        public async Task<IActionResult> Update(string id, Region updatedRegion)
        {
            var region = await _regionesService.GetAsync(id);

            if (region is null)
            {
                return NotFound();
            }

            updatedRegion.Id = region.Id;

            await _regionesService.UpdateAsync(id, updatedRegion);

            return NoContent();
        }

        [HttpDelete("{id:length(24)}")]
        public async Task<IActionResult> Delete(string id)
        {
            var region = await _regionesService.GetAsync(id);

            if (region is null)
            {
                return NotFound();
            }

            await _regionesService.RemoveAsync(id);

            return NoContent();
        }

    }
}
