using System.Collections.Generic;
using EventManager.Core.CoreEntities;

namespace EventManager.Core.Core
{
    public interface IRepository<T> where T : BaseEntity
    {
        void Create(T entity);
        void Delete(int id);
        IEnumerable<T> GetAll();
        T GetById(int id);
        void Edit(T entity);
    }
}
