using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Backend.Models
{
    public class PersonWithCars
    {
        public string  FullName { get; set; }
        public List<Car> Cars { get; set; }
    }
}
