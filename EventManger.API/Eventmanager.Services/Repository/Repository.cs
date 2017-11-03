using System;
using System.Collections.Generic;
using System.Security;
using EventManager.Common;
using EventManager.Core.Core;
using EventManager.Core.CoreEntities;
using Microsoft.Azure.Documents.Client;

namespace Eventmanager.Services.Repository
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        public void Create(T entity)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<T> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public T GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Edit(T entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
