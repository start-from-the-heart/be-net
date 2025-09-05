using ECommerceFarming.Entity.Entity.Login;
using ECommerceFarming.Infrastructure.Common;
using ECommerceFarming.Infrastructure.Reponsitory.Login.Interface;

namespace ECommerceFarming.Infrastructure.Reponsitory.Login
{
    public class LoginReponsitory : Repository<User>, ILoginReponsitory
    {
    }
}