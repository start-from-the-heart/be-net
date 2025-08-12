namespace LibraryManagementSystem.Entity.Common
{
    public class CommonEntity
    {
        public int DeleteFlg { get; set; }

        public DateTime CreateDate { get; set; }

        public DateTime UpdateDate { get; set; }

        public string? CreateUser { get; set; }

        public string? UpdateUser { get; set; }
    }
}