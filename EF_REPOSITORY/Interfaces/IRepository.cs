using System.Linq;

namespace EF.Interfaces
{
    public interface IRepository<T>
    {
        T Add(T entity);
        T Remove(T entity);
        T Update(T entity);
        IQueryable<T> GetAll();
        T Get(object key);
        void SaveChanged();
    }
}
