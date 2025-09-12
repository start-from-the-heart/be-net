using ECommerceFarming.Infrastructure.Reponsitory.Login.Interface;

namespace ECommerceFarming.Infrastructure.UnitOfWork.Interface
{
    public interface IUnitOfWork : IDisposable
    {
        int Complete();

        void BeginTransaction();

        void Commit();

        void Rollback();

        ILoginReponsitory LoginReponsitory { get; }
    }
}