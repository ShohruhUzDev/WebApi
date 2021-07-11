using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Backend.Models;

namespace WebApi.Backend.ServiceLayer
{
    public class CarService : IRepository<Car, int>
    {
        private DataConext _dataContext;

        public CarService(DataConext dataConext)
        {
            _dataContext = dataConext;
        }

        public async Task<Car> Create(Car car)
        {
            var sbk=await _dataContext.Cars.AddAsync(car);
            _dataContext.SaveChanges();
            return sbk.Entity;

            
        }
        



        public async Task< IEnumerable<Car>> GetAll()
        {
            var cars = await _dataContext.Cars.ToListAsync();
            return cars;
        }

        public async Task<Car> GetById(int id)
        {
            return await _dataContext.Cars.FirstOrDefaultAsync(i => i.Id == id);

        }

      
        public async Task Delete(int id)
        {
            var car1 =  await _dataContext.Cars.FirstOrDefaultAsync(i => i.Id == id);
            if (car1 != null)
            {
                _dataContext.Cars.Remove(car1);
                _dataContext.SaveChanges();
            }
         


        }

    

        async Task IRepository<Car, int>.Update(Car entity)
        {
            var car = await _dataContext.Cars.FirstOrDefaultAsync(i => i.Id == entity.Id);
            if (car != null)
            {
                _dataContext.Entry(entity).State = EntityState.Modified;
                _dataContext.SaveChanges();
            }
            
        }
    }
}
