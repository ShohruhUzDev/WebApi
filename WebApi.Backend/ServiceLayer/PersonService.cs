using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Backend.Models;

namespace WebApi.Backend.ServiceLayer
{
    public class PersonService : IPersonService
    {
        private readonly DataConext _datacontext;
        public PersonService(DataConext dataConext)
        {
            this._datacontext = dataConext;
        }
        public Person Get(int id)
        {
           var person= _datacontext.Persons.FirstOrDefault(i => i.Id == id);

            return person;
        }

        public IEnumerable<Person> GetAll()
        {
            var persons = _datacontext.Persons.ToList();
            return persons;
        }

        public Person GetPersonWithCar(int id)
        {
            var person = _datacontext.Persons.Include(i => i.Cars).FirstOrDefault(j => j.Id == id);
            return person;
        }
    }
}
