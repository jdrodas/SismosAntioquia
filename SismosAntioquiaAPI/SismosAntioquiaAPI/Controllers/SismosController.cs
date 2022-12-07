using SismosAntioquiaAPI.Models;
using SismosAntioquiaAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace SismosAntioquiaAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SismosController : ControllerBase
    {
        private readonly SismosService _sismosService;

        public SismosController(SismosService sismosService) =>
            _sismosService = sismosService;

        [HttpGet]
        public async Task<List<Sismo>> Get() =>
            await _sismosService.GetAsync();

        [HttpGet("{id:length(24)}")]
        public async Task<ActionResult<Sismo>> Get(string id)
        {
            var sismo = await _sismosService.GetAsync(id);

            if (sismo is null)
            {
                return NotFound();
            }

            return sismo;
        }

        [HttpPost]
        public async Task<IActionResult> Post(Sismo newSismo)
        {
            await _sismosService.CreateAsync(newSismo);

            return CreatedAtAction(nameof(Get), new { id = newSismo.Id }, newSismo);
        }

        [HttpPut("{id:length(24)}")]
        public async Task<IActionResult> Update(string id, Sismo updatedSismo)
        {
            var sismo = await _sismosService.GetAsync(id);

            if (sismo is null)
            {
                return NotFound();
            }

            updatedSismo.Id = sismo.Id;

            await _sismosService.UpdateAsync(id, updatedSismo);

            return NoContent();
        }

        [HttpDelete("{id:length(24)}")]
        public async Task<IActionResult> Delete(string id)
        {
            var sismo = await _sismosService.GetAsync(id);

            if (sismo is null)
            {
                return NotFound();
            }

            await _sismosService.RemoveAsync(id);

            return NoContent();
        }
    }
}
