using System.Linq.Expressions;

namespace ECommerceFarming.Infrastructure.Common.Interface
{
    public interface IRepository<T>
    {
        T GetById(int id);

        void Update(T entity);

        void Delete(T entity);

        void Add(T entity);

        IEnumerable<T> GetAll();

        IEnumerable<T> Find(Expression<Func<T, bool>> predicate);

        void SaveChange();
    }
}