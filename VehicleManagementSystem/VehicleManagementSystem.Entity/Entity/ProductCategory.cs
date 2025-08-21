using System.ComponentModel.DataAnnotations;
using VehicleManagementSystem.Entity.Common;

namespace VehicleManagementSystem.Entity.Entity
{
    public class ProductCategory : EntityCommon
    {
        public long ProductCategoryId { get; set; }

        [MaxLength(250)]
        public string CategoryName { get; set; } = string.Empty;

        public long ParentCategoryId { get; set; }
    }
}