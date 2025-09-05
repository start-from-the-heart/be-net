using ECommerceFarming.Entity.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerceFarming.Entity.Entity.Login
{
    public class User : BaseEntity
    {
        [Key, Required]
        public long UserId { get; set; }

        [MaxLength(100)]
        public string? UserName { get; set; }

        [MaxLength(100)]
        public string Email { get; set; } = string.Empty;

        [Required, MaxLength(200)]
        public string Password { get; set; } = string.Empty;

        [Required, MaxLength(200)]
        public string ConfirmPassword { get; set; } = string.Empty;

        [Required, Column("numeric(2,0)")]
        public int RoleID { get; set; }

        public bool IsBanned { get; set; } = false;

        public DateTime Expired { get; set; } = DateTime.Now;
    }
}