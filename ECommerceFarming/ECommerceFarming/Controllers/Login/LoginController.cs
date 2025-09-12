using ECommerceFarming.Entity.Common;
using ECommerceFarming.Entity.Model.Request.Login;
using ECommerceFarming.Entity.Model.Response.Login;
using ECommerceFarming.Helper.Common;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceFarming.Controllers.Login
{
    [ApiController]
    public class LoginController : ControllerBase
    {
        [HttpPost(RouteCommon.LoginURL)]
        public BaseResponse<LoginResponseModel> Login([FromBody] LoginRequestModel requestModel)
        {
            return new BaseResponse<LoginResponseModel>(new LoginResponseModel(), StatusCodes.Status200OK, "Success");
        }
    }
}