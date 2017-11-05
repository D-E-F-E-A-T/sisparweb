using Sispar.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sispar.Core.Contracts
{
    public interface IRepository<T> : IDisposable where T : Entity
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
        T Add(T obj);
        T Edit(T obj);
        void Delete(T obj);
    }
}
