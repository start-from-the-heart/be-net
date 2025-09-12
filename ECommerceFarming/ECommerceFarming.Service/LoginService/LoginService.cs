using ECommerceFarming.Entity.Model.Request.Login;
using ECommerceFarming.Entity.Model.Response.Login;
using ECommerceFarming.Infrastructure.Reponsitory.Login.Interface;
using ECommerceFarming.Infrastructure.UnitOfWork.Interface;
using ECommerceFarming.Service.Common;
using ECommerceFarming.Service.LoginService.Interface;

namespace ECommerceFarming.Service.LoginService
{
    public class LoginService : BaseService, ILoginService
    {
        private readonly IUnitOfWork _unitOfWork;

        private readonly ILoginReponsitory _loginReponsitory;

        public LoginService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            _unitOfWork = unitOfWork;

            _loginReponsitory = _unitOfWork.LoginReponsitory;
        }

        public async Task<LoginResponseModel> Login(LoginRequestModel loginRequest)
        {
            try
            {
            }
            catch (Exception ex)
            {
                throw;
            }

            return null;
        }
    }
}