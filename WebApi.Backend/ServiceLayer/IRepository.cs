using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Backend.ServiceLayer
{
   public interface IRepository<T1, T2> where T1:class
    {
        Task<IEnumerable<T1>> GetAll();
        Task<T1> GetById(T2 id);
        Task<T1> Create(T1 entity);
        Task Delete(T2 id);
        Task Update(T1 entity);
      //  bool Exist(T2 id);

    }
}
