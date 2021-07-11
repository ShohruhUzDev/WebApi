using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Backend.ServiceLayer;

namespace WebApi.Backend.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class CarController : ControllerBase
    {
        private readonly ICarService _carService;

        public CarController(ICarService carService)
        {
            _carService = carService;

        }

       [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var car = await _carService.Get(id);
            return Ok(car);
        }


        [HttpGet]
        public async Task< IActionResult> GetAll()
        {
            var cars = await _carService.GetAll();
            return Ok(cars);
        }


    }
}
