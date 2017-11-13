using System;
using System.Collections.Generic;
using System.Text;
using EventManager.Common;
using EventManager.Core.Data;
using EventManager.Core.Entities;
using Microsoft.Azure.Documents.Client;

namespace EventManger.Data.Repository
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private DocumentClient _client = new DocumentClient(new Uri(Common.EndpointUri), Common.PrimaryKey);
        public void Insert(T entity)
        {
            throw new NotImplementedException();
        }

        public void InsertRange(List<T> entities)
        {
            throw new NotImplementedException();
        }

        public T Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }
    }
}
