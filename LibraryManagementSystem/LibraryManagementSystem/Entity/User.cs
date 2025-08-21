using LibraryManagementSystem.Entity.Common;

namespace LibraryManagementSystem.Entity.Entity
{
    public class User : CommonEntity
    {
        public long UserID { get; set; }

        public string UserName { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public string Password { get; set; } = string.Empty;

        public string PhoneNumber { get; set; } = string.Empty;

        public string BorrowedBooks { get; set; }

        public long RoleID { get; set; }

        public User()
        {
        }

        public User(long userID, string userName, string email, string password, string phoneNumber, string borrowedBooks, long roleID)
        {
            UserID = userID;
            UserName = userName;
            Email = email;
            Password = password;
            PhoneNumber = phoneNumber;
            BorrowedBooks = borrowedBooks;
            RoleID = roleID;
        }

        public virtual string GetInformationUser()
        {
            return $"{UserID} - {UserName} - {PhoneNumber}";
        }

        public virtual string ViewData()
        {
            return "";
        }
    }
}