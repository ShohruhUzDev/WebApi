using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Backend.Models;

namespace WebApi.Backend.ServiceLayer
{
    public class CarService : ICarService
    {
        private DataConext _dataContext;

        public CarService(DataConext dataConext)
        {
            _dataContext = dataConext;
        }
        public Car Get(int id)
        {
            return _dataContext.Cars.FirstOrDefault(i => i.Id == id);

        }

        public IEnumerable<Car> GetAll()
        {
            var cars = _dataContext.Cars.ToList();
            return cars;
        }
    }
}
