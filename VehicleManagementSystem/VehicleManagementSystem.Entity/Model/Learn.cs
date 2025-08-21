namespace VehicleManagementSystem.Entity.Model
{
    internal class Learn
    {
        /*
         * Value Type :
         *              - Simple Type : int, float, double, boolearn,  char, DateTime, long, short (object)
         *              - Enum Type
         *              - Struct Type
         *              - Nullable Type
         *
         * Reference type:
         *              - string
         *              - Class type
         *              - Interface Type
         *              - Array Type
         *              - Delegate Type
         */

        private Learn learnmethod = new Learn();

        //private int num = 100;

        //public Enum Enum { get; set; }

        //private struct  TotalValue
        //{
        //    value1

        //}

        //private float rate = 10.2f;

        //private decimal amount = 100.50M;

        //private char code = 'C';

        //private bool isValid = true;

        //private string name = "hoang minh dep trai";

        private int _learnId;

        public int LearnId
        {
            get { return _learnId; }
            set
            {
                checked
                {
                    if (_learnId < 0)
                    {
                        throw new ArgumentException($"{_learnId} not less than 0");
                    }
                    else
                    {
                        _learnId = value;
                    }
                }

                //Unsafe
                //unsafe
                //{
                //    int[] nums = { 1, 2, 3 };
                //    fixed (int* p = nums)
                //    {
                //        Console.WriteLine(*p);  // In ra 1
                //    }
                //}
            }
        }

        //lock ho tro  data luong
        //private static readonly object _lock = new object();

        //private int counter = 0;

        //private void IncreaseCounter()
        //{
        //    lock (_lock)
        //    {
        //        counter++;
        //    }
        //}

        //// example yield
        //public IEnumerable<int> GetNumber()
        //{
        //    for (int i = 0; i < 10; i++)
        //    {
        //        yield return i;
        //    }
        //}

        // Cơ chế hoạt động của Garbage Collection

        //Tracking: GC theo dõi các object trên heap.

        //Mark: Đánh dấu các object vẫn còn được tham chiếu từ stack hoặc static.

        //Sweep: Dọn dẹp(giải phóng) các object không còn được tham chiếu.

        //Compact(nén): Di chuyển object còn sống lại gần nhau để tránh phân mảnh bộ nhớ.

        // example :
        // value type
        private int valueType = 0;

        private string status = "sayHello";

        // refercence type
        public List<int> listNumbers = new List<int>();

        public int Number(out int x, out int y)
        {
            x = 0;
            y = 0;
            return x + y;
        }

        public int number(ref int x, ref int y)
        {
            return x + y;
        }

        //assigns default value 01/01/0001 00:00:00
        private DateTime dt1 = new DateTime();

        //assigns year, month, day
        private DateTime dt2 = new DateTime(2015, 12, 31);

        //assigns year, month, day, hour, min, seconds
        private DateTime dt3 = new DateTime(2015, 12, 31, 5, 10, 20);

        //assigns year, month, day, hour, min, seconds, UTC timezone
        private DateTime dt4 = new DateTime(2015, 12, 31, 5, 10, 20, DateTimeKind.Utc);
    }

    internal class ValueTest
    {
        private Learn learn = new Learn();
    }

    //private class Learn1
    //{
    //}
}