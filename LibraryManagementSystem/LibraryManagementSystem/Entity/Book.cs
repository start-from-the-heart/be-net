using LibraryManagementSystem.Entity.Common;

namespace LibraryManagementSystem.Entity.Entity
{
    public class Book : CommonEntity
    {
        private long _bookID;

        public long BookID
        {
            get
            {
                return _bookID;
            }

            set
            {
                if (value == 0)
                {
                    throw new ArgumentNullException("value is not exits");
                }

                _bookID = value;
            }
        }

        public string Title { get; set; } = string.Empty;

        public string Author { get; set; } = string.Empty;

        public int Year { get; set; }

        public decimal Price { get; set; }

        public string ISBN { get; set; } = string.Empty;
    }
}