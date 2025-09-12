namespace Program
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            //Collection LIFO
            //Stack stack1 = new Stack();
            //stack1.Push(1);
            //stack1.Push("2");
            //stack1.Push("2");
            //stack1.Push(3);

            //var firstItem = stack1.Peek();

            //Console.WriteLine(firstItem);

            //Stack<int> stack = new Stack<int>();

            //stack.Push(42);
            //stack.Push(43);

            //foreach (var i in stack1)
            //{
            //    Console.WriteLine(i);
            //}

            //Stack<int> myStack = new Stack<int>();
            //myStack.Push(1);
            //myStack.Push(2);
            //myStack.Push(3);
            //myStack.Push(4);

            //myStack.Contains(2); // returns true

            //queue FIFO
            //Queue<int> queue = new Queue<int>();
            //queue.Enqueue(1);
            //queue.Enqueue(2);

            //foreach (var item in queue)
            //{
            //    Console.WriteLine(item);
            //}

            //Queue<string> strQ = new Queue<string>();
            //strQ.Enqueue("H");
            //strQ.Enqueue("e");
            //strQ.Enqueue("l");
            //strQ.Enqueue("l");
            //strQ.Enqueue("o");

            //Console.WriteLine("Total elements: {0}", strQ.Count); //prints 5

            //while (strQ.Count > 0)
            //    Console.WriteLine(strQ.Dequeue()); //prints Hello

            //Console.WriteLine("Total elements: {0}", strQ.Count);

            //add<int> sum = Sum;
            //Console.WriteLine(sum(10, 20));

            //add<string> con = Concat;
            //Console.WriteLine(Concat("Hello ", "World!!"));

            // Function Delegate
            Func<int, int, int> SumOffTowValue = Sum;

            Console.WriteLine("Function Delegate: " + SumOffTowValue(10, 10));

            // Function no Paramter
            Func<int> ShowNumber = AsTheResult;

            Console.WriteLine("Function Delegate No Paramter: " + ShowNumber());

            // Anonymous Method

            Func<int, int, int> showNumberOfData = delegate (int number, int number2)
            {
                return number;
            };

            Console.WriteLine("Function Delegate with anoymous method: " + showNumberOfData(3, 2));

            // Function with lamda

            Func<int> getRandomNumber = () => new Random().Next(1, 100);

            Func<int, int, int> SumTwoValue = (x, y) => x + y;

            Console.WriteLine("Function Delegate with lamda: " + getRandomNumber());

            // Great than max 16 value in funcion delegate

            // Action DeleteGate is not return

            static void ConsolePrint(int i)
            {
                Console.WriteLine("Action Delegate: " + i);
            }

            Action<int> action = ConsolePrint;

            action(1);

            // Predict Delegate get 1 value input and return value boolean in required

            static bool IsUpperCase(string str)
            {
                return str.Equals(str.ToUpper());
            }

            Predicate<string> isUpperCase = IsUpperCase;

            Console.WriteLine(isUpperCase("VALUE"));

            // anonymous method
            //It cannot contain jump statement like goto, break or continue.
            //It cannot access ref or out parameter of an outer method.
            //It cannot have or access unsafe code.
            //It cannot be used on the left side of the is operator.

            //ProcessBusinessLogic bl = new ProcessBusinessLogic();
            //bl.ProcessCompleted += bl_ProcessCompleted; // register with an event
            //bl.StartProcess();

            List<int> value = new List<int>() { 1, 2, 3 };

            var test = value.Where(x => x > 0).ToList();
        }

        // event handler
        //public static void bl_ProcessCompleted()
        //{
        //    Console.WriteLine("Process Completed!");
        //}

        //prints 0

        // exception là cha của các exception
        // SystemException lỗi xảy ra trong hệ thống khi build-in function
        // ApplicationException is customerise exception if symstem is casing of it.

        //try
        //{
        //    Console.WriteLine("Enter a number: ");

        //    var num = int.Parse(Console.ReadLine());

        //    Console.WriteLine($"Squre of {num} is {num * num}");
        //}
        //catch
        //{
        //    Console.Write("Error occurred.");
        //}
        //finally
        //{
        //    Console.Write("Re-try with a different number.");
        //}

        // Delegate is reference type
        // 1. Declare a delegate
        //2. Create an instance and reference a method
        //3.Invoke a delegate

        // thanh phan cua delegate
        // [access modifier] delegate [return type] [delegate name]([parameters])

        public static int Sum(int val1, int val2)
        {
            return val1 + val2;
        }

        public static string Concat(string str1, string str2)
        {
            return str1 + str2;
        }

        public static int AsTheResult()
        {
            Console.WriteLine("1");

            return -1;
        }
    }

    public delegate T add<T>(T param1, T param2);

    public class CustomerExceltion : ApplicationException
    {
        public CustomerExceltion(string message) : base(message)
        {
            throw new ApplicationException(message);
        }
    }
}