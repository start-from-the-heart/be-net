namespace Program
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Random random = new Random();
            List<int> numbers = new List<int>();

            for (int i = 0; i < 20; i++)
            {
                int num = random.Next(1, 101);
                numbers.Add(num);
            }

            Console.WriteLine("Danh sách số :");
            foreach (int n in numbers)
            {
                Console.Write(n + " ,");
            }

            Console.WriteLine("");
            // Find Min Max
            //int max = 0;

            //C1:
            //for (int i = 0; i < numbers.Count; i++)
            //{
            //    if (numbers[i] > max) max = numbers[i];
            //}

            //C2 sort danh sach
            //numbers.Sort();
            //max = numbers[numbers.Count - 1];

            //C3 : Binary Search
            //max = FindMax(numbers);
            //Console.WriteLine($"Number max: {max}");

            // Dao nguoc mang
            // vd 1,2,3,7,8 -> 8, 7 , 3 ,2,1

            //C1
            //var listSwap = SwapItemInList(numbers);
            //foreach (int n in listSwap)
            //{
            //    Console.Write(n + " ,");
            //}

            //C2
            Stack<int> stack = new Stack<int>(numbers);

            List<int> revert = new List<int>(stack);

            foreach (int n in revert)
            {
                Console.Write(n + " ,");
            }
        }

        private static List<int> SwapItemInList(List<int> numbers)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                int number = 0;
                number = numbers[i];
                numbers[i] = numbers[numbers.Count - 1 - i];
                numbers[numbers.Count - 1 - i] = number;
            }

            return numbers;
        }

        private static int FindMax(List<int> numbers)
        {
            int left = 0, right = numbers.Count - 1;

            int max = 0;

            while (left < right)
            {
                int mid = left + (right - left) / 2;

                if (numbers[mid] < max)
                    left = mid + 1;
                else
                {
                    right = mid;
                    max = numbers[mid];
                }
            }

            return numbers[left];
        }
    }
}