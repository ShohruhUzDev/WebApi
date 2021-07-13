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
       Task<IEnumerable< Car>> GetPersonWithCar(int id);
    }
}
