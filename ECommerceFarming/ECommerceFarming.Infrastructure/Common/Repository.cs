using ECommerceFarming.Infrastructure.Common.Interface;
using ECommerceFarming.Infrastructure.Context;
using System.Linq.Expressions;

namespace ECommerceFarming.Infrastructure.Common
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly ECommerceDbContext _eCommerceDbContext;

        public Repository(ECommerceDbContext eCommerceDbContext)
        {
            _eCommerceDbContext = eCommerceDbContext;
        }

        public void Add(T entity)
        {
            _eCommerceDbContext.Set<T>().Add(entity);
        }

        public void Delete(T entity)
        {
            _eCommerceDbContext.Set<T>().Remove(entity);
        }

        public IEnumerable<T> Find(Expression<Func<T, bool>> predicate)
        {
            return _eCommerceDbContext.Set<T>().Where(predicate);
        }

        public IEnumerable<T> GetAll()
        {
            return _eCommerceDbContext.Set<T>();
        }

        public T GetById(int id)
        {
            var entity = _eCommerceDbContext.Set<T>().Find(id);
            if (entity == null)
            {
                throw new KeyNotFoundException($"Entity {typeof(T).Name} with id {id} not found.");
            }
            return entity;
        }

        public void SaveChange()
        {
            _eCommerceDbContext.SaveChanges();
        }

        public void Update(T entity)
        {
            _eCommerceDbContext.Set<T>().Update(entity);
        }
    }
}