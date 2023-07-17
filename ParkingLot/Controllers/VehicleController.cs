using Microsoft.AspNetCore.Mvc;
using ParkingLot.Project.Backend.Application.Services;
using ParkingLot.Project.Backend.Domain.Entities;

namespace ParkingLot.Project.Backend.Web.Controllers
{
    [ApiController]
    [Route("api/[Vehicle]")]
    public class VehicleController : ControllerBase
    {
        private readonly VehicleService _vehicleService;

        public VehicleController(VehicleService vehicleService)
        {
            this._vehicleService = vehicleService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Vehicle>>> GetAllVehicles()
        {
            List<Vehicle> vehicles = await _vehicleService.GetAllVehicles();
            return Ok(vehicles);
        }

        [HttpGet("{plate}")]
        public async Task<ActionResult<Vehicle>> GetVehicleByPlate(string plate)
        {
            Vehicle vehicle = await _vehicleService.GetVehicleByPlate(plate);

            if (vehicle == null)
            {
                return NotFound();
            }
            return Ok(vehicle);
        }

        [HttpPost]
        public async Task<IActionResult> InsertEntry([FromBody] Vehicle vehicle)
        {
            await _vehicleService.InsertVehicleEntry(vehicle);
            return Ok();
        }

        [HttpPut("{plate}/exit")]
        public async Task<ActionResult> InsertExit(string plate)
        {
            await _vehicleService.InsertVehicleExit(plate);
            return Ok();
        }
    }
}
