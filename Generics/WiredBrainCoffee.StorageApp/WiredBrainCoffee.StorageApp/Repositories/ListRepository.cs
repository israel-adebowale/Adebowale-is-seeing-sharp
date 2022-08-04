using WiredBrainCoffee.StorageApp.Entities;

namespace WiredBrainCoffee.StorageApp.Repositories
{
    public partial class ListRepository<T> : IRepository<T> where T : IEntity
    {
        protected readonly List<T> _items = new();
        public T GetById(int id)
        {
            return _items.Single(item => item.Id == id);
        } 
        public IEnumerable<T> GetAll()
        {
            return _items.ToList();
        }
        public void Add(T item)
        {
            item.Id = _items.Count + 1;
            _items.Add(item);
        }
        public void Remove(T item)
        {
            _items.Remove(item);
        }
        public void Save()
        {
            //foreach (var item in _items)
            //{
            //    Console.WriteLine(item);
            //}
        }

       
    }




}
