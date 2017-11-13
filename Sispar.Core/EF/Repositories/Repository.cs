using Sispar.Core.Contracts;
using Sispar.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sispar.Core.EF.Repositories
{
    public class Repository<T> : IRepository<T> where T : Entity
    {
        protected readonly SisparDataContext _ctx = new SisparDataContext();

        public T Add(T obj)
        {
            _ctx.Set<T>().Add(obj);
            _ctx.SaveChanges();
            return obj;
        }

        public void Delete(T obj)
        {
            _ctx.Set<T>().Remove(obj);
            _ctx.SaveChanges();
        }

        public void Dispose()
        {
            _ctx.Dispose();
        }

        public T Edit(T obj)
        {
            _ctx.Entry(obj).State = System.Data.Entity.EntityState.Modified;
            _ctx.SaveChanges();
            return obj;
        }

        public IEnumerable<T> GetAll()
        {
            return _ctx.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            return _ctx.Set<T>().Find(id);
        }
    }
}
