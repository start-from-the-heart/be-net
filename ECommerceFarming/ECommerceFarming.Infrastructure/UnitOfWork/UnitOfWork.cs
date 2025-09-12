using ECommerceFarming.Infrastructure.Context;
using ECommerceFarming.Infrastructure.Reponsitory.Login;
using ECommerceFarming.Infrastructure.Reponsitory.Login.Interface;
using ECommerceFarming.Infrastructure.UnitOfWork.Interface;
using Microsoft.EntityFrameworkCore.Storage;

namespace ECommerceFarming.Infrastructure.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ECommerceDbContext _eCommerceDbContext;

        private IDbContextTransaction? _transaction;

        private ILoginReponsitory? _loginReponsitory;

        public ILoginReponsitory LoginReponsitory
            => _loginReponsitory ??= new LoginReponsitory(_eCommerceDbContext);

        public UnitOfWork(ECommerceDbContext eCommerceDbContext)
        {
            _eCommerceDbContext = eCommerceDbContext;
        }

        public int Complete()
        {
            return _eCommerceDbContext.SaveChanges();
        }

        public void Dispose()
        {
            _transaction?.Dispose();
            _eCommerceDbContext.Dispose();
        }

        // Start transaction
        public void BeginTransaction()
        {
            _transaction = _eCommerceDbContext.Database.BeginTransaction();
        }

        // Commit transaction
        public void Commit()
        {
            try
            {
                _eCommerceDbContext.SaveChanges();
                _transaction?.Commit();
            }
            catch
            {
                Rollback();
                throw;
            }
        }

        // Rollback transaction
        public void Rollback()
        {
            _transaction?.Rollback();
        }
    }
}