namespace Console_Blank_6
{
    internal class Program
    {

        static void PrintElements(string[] data)
        {
            for (int i = 0; i<data.Length; i++)
            {
                Console.WriteLine(data[i]);
            }
               
        }

        static void IntArrAdder(int[] integerarray)
        {
            int sum = 0;
            for (int i = 0; i < integerarray.Length; i++)
            {
                sum += integerarray[i];
            }
            Console.WriteLine($"The sum is: {sum}");
        }

        static void PrimeChecker(int number)
        {
            bool isPrime = true;
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                    break;
                }
                if (i == number)
                {
                    break;
                }

            }
            if (isPrime)
            {
                Console.WriteLine($"{number} is a prime number.");
            }
            else
            {
                Console.WriteLine($"{number} is not a prime number.");
            }
        }

        static void BubbleSort(int[] array)
        {
            int n = array.Length;
            bool unsorted = true;
            while (unsorted)
            {
                unsorted = false;
                for (int i = 0; i < n - 1; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        int temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                        unsorted = true;
                    }
                }
            }
            Console.WriteLine("Sorted array: " + string.Join(", ", array));
        }

        static int BinarySearch(int[] sortedArray, int target)
        {
            int mid = -1;
            int left = 0;
            int right = sortedArray.Length - 1;
            while (left <= right)
            {
                mid = left + (right - left) / 2;
                if (sortedArray[mid] == target)
                {
                    Console.WriteLine($"Element found at index {mid}");
                    return(mid);
                }
                if (sortedArray[mid] < target)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
            return(mid);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            PrintElements(new string[] { "One", "Two", "Three" });  
            IntArrAdder(new int[] { 1, 2, 3, 4, 5 });
            PrimeChecker(15);
            BubbleSort(new int[] { 64, 34, 25, 12, 22, 11, 90,1234,4324,324,62,344,6,63,6,77,54,456,443 });
            int WhereFound = BinarySearch(new int[] { 11, 12, 22, 25, 34, 64, 90, }, 11);
            Console.WriteLine($"Element found at index {WhereFound}");
        }
    }
}