using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApi.Backend.Models;
using WebApi.Backend.ServiceLayer;

namespace WebApi.Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        private DataConext _context;
        private IRepository<Car, int> _repository;

        public CarsController(IRepository<Car , int> repository)
        {
            _repository = repository;
        }

        // GET: api/Cars
        [HttpGet]
        public async Task<IEnumerable<Car>> GetCars()
        {
            return await  _repository.GetAll();
        }

        // GET: api/Cars/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Car>> GetCar(int id)
        {
            var car = await _repository.GetById(id);

            if (car == null)
            {
                return NotFound();
            }

            return car;
        }

        // PUT: api/Cars/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut]
        public async Task<IActionResult> PutCar(Car car)
        {
            //if (id != car.Id)
            //{
            //    return BadRequest();
            //}

          
            try
            {
                await _repository.Update(car);

                //  await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                //if (CarExists(id) == false)
                //{
                   return NotFound();
                //}
                //else
                //{
                //    throw;
                //}
            }

            return NoContent();
        }

        // POST: api/Cars
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        //public async Task<ActionResult<Car>> PostCar(Car car)
        //{
        //    //_context.Cars.Add(car);
        //    //await _context.SaveChangesAsync();

        //    //return CreatedAtAction("GetCar", new { id = car.Id }, car);
        //}

        // DELETE: api/Cars/5
        [HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteCar(int id)
        //{
        //    //var car = await _context.Cars.FindAsync(id);
        //    //if (car == null)
        //    //{
        //    //    return NotFound();
        //    //}

        //    //_context.Cars.Remove(car);
        //    //await _context.SaveChangesAsync();

        //    //return NoContent();
        //}

        private   bool CarExists(int id)
        {
            return  _context.Cars.Any(e => e.Id == id);
        }
    
    }
}
