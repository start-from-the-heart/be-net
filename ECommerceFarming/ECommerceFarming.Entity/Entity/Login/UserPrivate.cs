using ECommerceFarming.Entity.Common;
using System.ComponentModel.DataAnnotations;

namespace ECommerceFarming.Entity.Entity.Login
{
    public class UserPrivate : BaseEntity
    {
        [Key, Required]
        public long UserID { get; set; }

        [MaxLength(200)]
        public string? Address { get; set; }

        [MaxLength(13)]
        public string? PhoneNumber { get; set; }

        [MaxLength(15)]
        public string? NumberOfCard { get; set; }
    }
}