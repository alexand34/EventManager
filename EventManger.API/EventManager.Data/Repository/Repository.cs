using System.Collections.Generic;
using System.Linq;
using EventManager.Core.Core;
using EventManager.Core.CoreEntities;
using EventManager.Data;


namespace Eventmanager.Services.Repository
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly Context _context;

        public IEnumerable<T> GetAll()
        {
            return _context.Set<T>();
        }

        public T GetById(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public void Create(T entity)
        {
            _context.Set<T>().Add(entity);
        }

        public void Edit(T entity)
        {
            _context.Set<T>().Update(entity);
        }

        public void Delete(int id)
        {
            _context.Set<T>().Remove(_context.Set<T>().Find(id));
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
