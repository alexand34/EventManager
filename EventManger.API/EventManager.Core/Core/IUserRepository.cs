using EventManager.Core.CoreEntities;

namespace EventManager.Core.Core
{
    public interface IUserRepository<T> where T: BaseEntity
    {
        void AddUser(T entity);
        void BanUser(int id);
        void ForewanUser(int id);
        T GetUserInfo();

    }
}
