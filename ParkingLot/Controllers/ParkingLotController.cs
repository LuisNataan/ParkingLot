using Microsoft.AspNetCore.Mvc;
using ParkingLot.Project.Backend.Application.Services;
using ParkingLot.Project.Backend.Domain.Entities;

namespace ParkingLot.Project.Backend.Web.Controllers
{
    [ApiController]
    [Route("api/[ParkingLot]")]
    public class ParkingLotController : ControllerBase
    {
        private readonly ParkingLotService _parkingLotService;
        private readonly VehicleService _vehicleService;

        public ParkingLotController(ParkingLotService parkingLotService, VehicleService vehicleService)
        {
            this._parkingLotService = parkingLotService;
            this._vehicleService = vehicleService;
        }

        [HttpPost]
        public async Task<ActionResult> InsertEntryTime([FromBody] Vehicle vehicle)
        {
            await _vehicleService.InsertVehicleEntry(vehicle);
            return Ok(vehicle);
        }

        [HttpPut("{plate}")]
        public async Task<ActionResult> InsterExitTime(string plate)
        {
            await _vehicleService.InsertVehicleExit(plate);
            return Ok(plate);
        }

        [HttpGet("{plate}/charged-price")]
        public async Task<ActionResult<decimal>> CalculateChargedPrice(string plate, [FromQuery] DateTime entryTime, [FromQuery] DateTime exitTime)
        {
            decimal chargedPrice = await _parkingLotService.CalculateChargedPrice(plate, entryTime, exitTime);
            return Ok(chargedPrice);
        }
    }
}
