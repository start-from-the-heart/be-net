using System.Linq.Expressions;

namespace ECommerceFarming.Infrastructure.Common.Interface
{
    public interface IRepository<T>
    {
        T Get(int id);

        T GetById(int id);

        T Update(T entity);

        T Delete(int id);

        T Add(T entity);

        IEnumerable<T> GetAll();

        IEnumerable<T> Find(Expression<Func<T, bool>> predicate);

        void SaveChange();
    }
}