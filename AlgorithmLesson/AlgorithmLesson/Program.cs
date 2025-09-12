namespace Program
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Random random = new Random();
            //List<int> numbers = new List<int>();

            //for (int i = 0; i < 20; i++)
            //{
            //    int num = random.Next(1, 101);
            //    numbers.Add(num);
            //}

            //Console.WriteLine("Danh sách số :");
            //foreach (int n in numbers)
            //{
            //    Console.Write(n + " ,");
            //}

            ////// Find Min Max
            //int max = 0;
            //Console.WriteLine("");
            ////C1:
            //for (int i = 0; i < numbers.Count; i++)
            //{
            //    if (numbers[i] > max) max = numbers[i];
            //}

            //Console.WriteLine(max);

            //C2 sort danh sach
            //numbers.Sort();
            //max = numbers[numbers.Count - 1];

            //C3: Binary Search
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
            //Stack<int> stack = new Stack<int>(numbers);

            //List<int> revert = new List<int>(stack);

            //foreach (int n in revert)
            //{
            //    Console.Write(n + " ,");
            //}

            //QuickSort
            //   QuickSort dùng để giải quyết bài toán sắp xếp:

            //   Input: Một mảng/ danh sách các phần tử(thường là số, nhưng có thể mở rộng cho chuỗi, object có khóa so sánh).

            //   Output: Mảng đã được sắp xếp tăng dần(hoặc giảm dần).

            //int[] arr = { 34, 12, 78, 56, 1, 99, 23 };

            //Console.WriteLine("Mảng ban đầu: " + string.Join(", ", arr));

            //QuickSort(arr, 0, arr.Length - 1);

            //Console.WriteLine("Mảng đã sắp xếp: " + string.Join(", ", arr));

            // Merger Sort

            //int[] arr = { 34, 12, 78, 56, 1 };

            //Console.WriteLine("Mảng ban đầu: " + string.Join(", ", arr));

            //MergeSort(arr, 0, arr.Length - 1);   // gọi hàm

            //Console.WriteLine("Mảng đã sắp xếp: " + string.Join(", ", arr));
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

        private static void QuickSort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                var pivotIndex = Partition(arr, left, right);
                QuickSort(arr, left, pivotIndex - 1);
                QuickSort(arr, pivotIndex + 1, right);
            }
        }

        private static int Partition(int[] arr, int left, int right)
        {
            int pivot = arr[right];  // chọn pivot là phần tử cuối
            int i = left - 1;

            for (int j = left; j < right; j++)
            {
                if (arr[j] <= pivot)
                {
                    i++;
                    (arr[i], arr[j]) = (arr[j], arr[i]); // swap
                }
            }

            // Đưa pivot về đúng chỗ
            (arr[i + 1], arr[right]) = (arr[right], arr[i + 1]);
            return i + 1; // trả về vị trí pivot
        }

        private static void MergeSort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int mid = (left + right) / 2;

                // Array left
                MergeSort(arr, left, mid);

                // Array Right
                MergeSort(arr, mid + 1, right);

                // Merger array right and left
                MergeTwoArray(arr, left, mid, right);
            }
        }

        private static void MergeTwoArray(int[] arr, int left, int mid, int right)
        {
            int n1 = mid - left + 1;
            int n2 = right - mid;

            int[] L = new int[n1];
            int[] R = new int[n2];

            for (int i = 0; i < n1; i++) L[i] = arr[left + i];
            for (int j = 0; j < n2; j++) R[j] = arr[mid + 1 + j];

            int k = left, iL = 0, iR = 0;

            while (iL < n1 && iR < n2)
            {
                if (L[iL] <= R[iR]) arr[k++] = L[iL++];
                else arr[k++] = R[iR++];
            }

            while (iL < n1) arr[k++] = L[iL++];
            while (iR < n2) arr[k++] = R[iR++];
        }
    }
}