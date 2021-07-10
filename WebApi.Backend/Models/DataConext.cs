using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Backend.Models
{
    public class DataConext:DbContext
    {
        public DataConext(DbContextOptions<DataConext> options):base(options)
        {

        }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Person> Persons { get; set; }


    }
}
