using System.ComponentModel.DataAnnotations;
using VehicleManagementSystem.Entity.Common;

namespace VehicleManagementSystem.Entity.Entity
{
    public class Application : EntityCommon
    {
        [Key, Required]
        public long AppId { get; set; }

        public string Headline { get; set; } = string.Empty;

        public int PriceGel { get; set; }

        public int PriceUsd { get; set; }

        public DateTime AppRegisterDate { get; set; }

        [MaxLength(250)]
        public string ItemCondition { get; set; } = string.Empty;
    }
}