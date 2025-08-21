using LibraryManagementSystem.Entity.Common;

namespace LibraryManagementSystem.Entity.Entity
{
    public class Role : CommonEntity
    {
        public long RoleID { get; set; }

        public string RoleName { get; set; } = string.Empty;

        public long ParentRole { get; set; }
    }
}