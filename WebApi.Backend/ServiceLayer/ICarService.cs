using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Backend.Models;

namespace WebApi.Backend.ServiceLayer
{
    interface ICarService
    {
        Car Get(int id);
        IEnumerable<Car> GetAll();

    }
}
