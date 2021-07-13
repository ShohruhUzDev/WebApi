using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Backend.Models;
using System.Collections;

namespace WebApi.Backend.ServiceLayer
{
    //IRepository<Person, int>,
    public class PersonService :  IPersonService
    {
        private readonly DataConext _datacontext;
        public PersonService(DataConext dataConext)
        {
            this._datacontext = dataConext;
        }

        //public async Task<Person> Create(Person entity)
        //{
        //    await _datacontext.Persons.AddAsync(entity);
        //    _datacontext.SaveChanges();
        //    return entity;
        //}

        //public async Task Delete(int id)
        //{
        //    var person1 = await _datacontext.Persons.FirstOrDefaultAsync(i => i.Id == id);
        //    if (person1 != null)
        //    {
        //        _datacontext.Persons.Remove(person1);
        //        _datacontext.SaveChanges();
        //    }
        //}


        public async Task< IEnumerable<Person>> GetAll()
        {
            var persons = await _datacontext.Persons.ToListAsync();
            return persons;
        }

        public async Task<Person> Get(int id)
        {
            var person = await _datacontext.Persons.FirstOrDefaultAsync(i => i.Id == id);

            return person;
        }

        //public async Task Update(Person entity)
        //{
        //    var person = await _datacontext.Persons.FirstOrDefaultAsync(i => i.Id == entity.Id);
        //    if (person != null)
        //    {
        //        _datacontext.Entry(entity).State = EntityState.Modified;
        //        _datacontext.SaveChanges();
        //    };
        //}

        
        public async Task<bool> Exist(int id)
        {
            return await _datacontext.Persons.AnyAsync(e => e.Id == id);
        }
        public async Task<IEnumerable< Car>> GetPersonWithCar(int id)
        {
            var car = await _datacontext.Cars.Include(i => i.Person).Where(j=>j.Id==id).ToListAsync();
            //PersonWithCars personWithCars = new PersonWithCars()
            //{
            //    FullName=car.+" "+ car.LastName,
            //    CarName=car.Cars
            //};

            return car;
        }

    //    public Task<Person> Get(int id)
    //    {
    //        throw new NotImplementedException();
    //    }
    }
}
