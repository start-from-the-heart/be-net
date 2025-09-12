using ECommerceFarming.Infrastructure.UnitOfWork.Interface;

namespace ECommerceFarming.Service.Common
{
    public class BaseService
    {
        protected readonly IUnitOfWork _unitOfWork;

        protected BaseService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
    }
}