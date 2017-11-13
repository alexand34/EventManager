using System.Collections.Generic;
using EventManager.Core.Entities;

namespace EventManager.Core.Data
{
    public interface IRepository<T> where T : BaseEntity
    {
        void Insert(T entity);
        void InsertRange(List<T> entities);
        T Get(int id);
        List<T> GetAll();
        void Update(T entity);
        void Remove(int id);
    }
}
