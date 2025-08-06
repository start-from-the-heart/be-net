namespace VehicleManagementSystem.Entity.Model
{
    internal class Learn
    {
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
            }
        }

        //Unsafe
        //        unsafe
        //{
        //    int[] nums = { 1, 2, 3 };
        //        fixed (int* p = nums)
        //    {
        //        Console.WriteLine(*p);  // In ra 1
        //    }
        //}

        //lock ho tro  data luong
        private static readonly object _lock = new object();

        private int counter = 0;

        private void IncreaseCounter()
        {
            lock (_lock)
            {
                counter++;
            }
        }

        // example yield
        public IEnumerable<int> GetNumber()
        {
            for (int i = 0; i < 10; i++)
            {
                yield return i;
            }
        }
    }
}