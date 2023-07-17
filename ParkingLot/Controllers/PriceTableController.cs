using Microsoft.AspNetCore.Mvc;
using ParkingLot.Project.Backend.Application.Services;
using ParkingLot.Project.Backend.Domain.Entities;

namespace ParkingLot.Project.Backend.Web.Controllers
{
    [ApiController]
    [Route("api/[PriceTable]")]
    public class PriceTableController : ControllerBase
    {
        private readonly PriceTableService _priceTableService;

        public PriceTableController(PriceTableService priceTableService)
        {
            this._priceTableService = priceTableService;
        }

        [HttpGet]
        public async Task<ActionResult<List<PriceTable>>> GetPriceTables()
        {
            List<PriceTable> priceTables = await _priceTableService.GetPriceTables();
            return Ok(priceTables);
        }

        [HttpGet]
        public async Task<ActionResult<PriceTable>> GetPriceTableByDate([FromQuery] DateTime entryTime)
        {
            PriceTable priceTable = await _priceTableService.GetPriceTableByDate(entryTime);

            if (priceTable == null)
            {
                return NotFound();
            }
            return Ok(priceTable);
        }

        [HttpPost]
        public async Task<IActionResult> AddPriceTable([FromBody] PriceTable priceTable)
        {
            await _priceTableService.AddPriceTable(priceTable);
            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdatePriceTable(int id, [FromBody] PriceTable priceTable)
        {
            priceTable.Id = id;

            await _priceTableService.UpdatePriceTable(priceTable);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePriceTable(int id)
        {
            await _priceTableService.DeletePriceTable(id);
            return Ok();
        }
    }
}
