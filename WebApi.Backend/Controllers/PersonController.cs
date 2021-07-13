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
       // private IRepository<Person, int> _personService;
        private IPersonService _personService2;
        //IRepository<Person, int> personService, 
        public PersonController(IPersonService personService1)
        {
          //  _personService = personService;
            _personService2 = personService1;
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var person = await _personService2.Get(id);
            return Ok(person);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var persons =await _personService2.GetAll();
            return Ok(persons);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetPersonWihCar(int id)
        {
            var personwithcar = await _personService2.GetPersonWithCar(id);
                return Ok(personwithcar);
        }



    }
}
