using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Backend.Models;

namespace WebApi.Backend.ServiceLayer
{
   public interface ICarService
    {
        Task< Car> Get(int id);
       Task< IEnumerable<Car>> GetAll();
        void Update(Car car);
        void Delete(int id);
        Task<Car> Create(Car car);

    }
}
