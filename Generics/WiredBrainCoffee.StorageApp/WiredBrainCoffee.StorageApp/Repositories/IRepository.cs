using WiredBrainCoffee.StorageApp.Entities;

namespace WiredBrainCoffee.StorageApp.Repositories
{
    public interface IContravariance<in T>
    {
        void Add(T item);
        void Remove(T item);
        void Save();
    }
    public interface IUserRepository<out T>
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
    }
    public interface IRepository<T> : IUserRepository<T>, IContravariance<T> where T : IEntity
    {
        
    }
}