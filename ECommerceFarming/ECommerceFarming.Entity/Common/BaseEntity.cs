namespace ECommerceFarming.Entity.Common
{
    public class BaseEntity
    {
        public bool DeleteFlag { get; set; }

        public DateTime CreateDate { get; set; } = DateTime.Now;

        public DateTime UpdateDate { get; set; } = DateTime.Now;

        public string? CreateUser { get; set; }

        public string? UpdateUser { get; set; }
    }
}