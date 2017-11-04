using System;
using System.Collections.Generic;
using System.Text;
using EventManager.Core.Core;
using EventManager.Core.CoreEntities;

namespace Eventmanager.Services.Repository
{
    public class UserRepository<T> : IUserRepository<T> where T : BaseEntity
    {
        public void AddUser(T entity)
        {
            throw new NotImplementedException();
        }

        public void BanUser(int id)
        {
            throw new NotImplementedException();
        }

        public void ForewanUser(int id)
        {
            throw new NotImplementedException();
        }

        public T GetUserInfo()
        {
            throw new NotImplementedException();
        }
    }
}
