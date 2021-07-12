using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Backend.Models;
using System.Collections;

namespace WebApi.Backend.ServiceLayer
{
    public class PersonService : IRepository<Person, int>
    {
        private readonly DataConext _datacontext;
        public PersonService(DataConext dataConext)
        {
            this._datacontext = dataConext;
        }

        public async Task<Person> Create(Person entity)
        {
            await _datacontext.Persons.AddAsync(entity);
            return entity;
        }

        public async Task Delete(int id)
        {
            var person1 = await _datacontext.Persons.FirstOrDefaultAsync(i => i.Id == id);
            if (person1 != null)
            {
                _datacontext.Persons.Remove(person1);
                _datacontext.SaveChanges();
            }
        }


        public async Task< IEnumerable<Person>> GetAll()
        {
            var persons = await _datacontext.Persons.ToListAsync();
            return persons;
        }

        public async Task<Person> GetById(int id)
        {
            var person = await _datacontext.Persons.FirstOrDefaultAsync(i => i.Id == id);

            return person;
        }

        public async Task Update(Person entity)
        {
            var person = await _datacontext.Persons.FirstOrDefaultAsync(i => i.Id == entity.Id);
            if (person != null)
            {
                _datacontext.Entry(entity).State = EntityState.Modified;
                _datacontext.SaveChanges();
            };
        }

        
        public async Task<bool> Exist(int id)
        {
            return await _datacontext.Persons.AnyAsync(e => e.Id == id);
        }
        ////public async Task<PersonWithCars> GetPersonWithCar(int id)
        ////{
        ////    var car = _datacontext.Cars.Include(i=>i.PersonId)
        ////        //(car, person) =>
        ////        //new PersonWithCars
        ////        //{
        ////        //    FullName = person.FirstName + " " + person.LastName,
        ////        //    CarName = car.Name
        ////        //}
        ////        );
        ////    var newperson= from i in car
        ////                   where i.
        ////    return car;
        ////}
    }
}
