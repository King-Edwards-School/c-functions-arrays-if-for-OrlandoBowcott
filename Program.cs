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


        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            PrintElements(new string[] { "One", "Two", "Three" });  
            IntArrAdder(new int[] { 1, 2, 3, 4, 5 });
            PrimeChecker(15);
            BubbleSort(new int[] { 64, 34, 25, 12, 22, 11, 90,1234,4324,324,62,344,6,63,6,77,54,456,443 });
        }
    }
}