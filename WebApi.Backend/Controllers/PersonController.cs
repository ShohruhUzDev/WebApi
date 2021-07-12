using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Backend.Models;
using WebApi.Backend.ServiceLayer;

namespace WebApi.Backend.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private IRepository<Person, int> _personService;

        public PersonController(IRepository<Person, int> personService)
        {
            _personService = personService;
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var person = await _personService.GetById(id);
            return Ok(person);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var persons =await _personService.GetAll();
            return Ok(persons);
        }

        //[HttpGet]
        //public async Task<IActionResult> GetPersonWihCar(int id)
        //{
        //    var personwithcar = await _personService.GetPersonWithCar(id);
        //    return Ok(personwithcar);
        //}



    }
}
