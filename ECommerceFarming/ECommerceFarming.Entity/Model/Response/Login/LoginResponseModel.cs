namespace ECommerceFarming.Entity.Model.Response.Login
{
    public class LoginResponseModel
    {
        public string Token { get; set; } = string.Empty;

        public string? UserId { get; set; }

        public string? UserName { get; set; }

        public int RoleId { get; set; }
    }
}