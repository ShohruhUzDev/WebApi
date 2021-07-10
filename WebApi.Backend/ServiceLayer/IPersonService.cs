using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Backend.Models;

namespace WebApi.Backend.ServiceLayer
{
    interface IPersonService
    {
        Person Get(int id);
        IEnumerable<Person> GetAll();
        Person GetPersonWithCar(int id);
    }
}
