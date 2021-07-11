using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Backend.Models;

namespace WebApi.Backend.ServiceLayer
{
    public interface IPersonService
    {
        Task<Person> Get(int id);
       Task< IEnumerable<Person>> GetAll();
      // Task< PersonWithCars> GetPersonWithCar(int id);
    }
}
