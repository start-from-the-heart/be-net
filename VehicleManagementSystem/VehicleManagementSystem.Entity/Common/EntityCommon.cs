using System.ComponentModel.DataAnnotations;

namespace VehicleManagementSystem.Entity.Common
{
    public class EntityCommon
    {
        public bool DeleteFlag { get; set; } = false;

        [MaxLength(50)]
        public string CreateUser { get; set; } = string.Empty;

        [MaxLength(50)]
        public string UpdateUser { get; set; } = string.Empty;

        public DateTime CreateDate { get; set; } = DateTime.Now;

        public DateTime UpdateDate { get; set; } = DateTime.Now;
    }
}