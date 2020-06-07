using System;
using System.Diagnostics;
using System.Threading;

namespace SortAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Algorithm behave like bubbles in water.\nBiggest bubbles go faster than the smaller one.");
            Console.WriteLine("Check examples:");
            Console.ReadLine();

            Console.WriteLine("Example 1:"); //one bubble 100 is moving forward
            int[] arr = { 100, 1, 2, 3 };
            BubbleSort(arr);

            Console.WriteLine("Example 2:"); //two bubbles 100 and 1
            int[] arr1 = { 100, 1,-1, 2, 3 };
            BubbleSort(arr1);

            Console.WriteLine("Example 3:"); //all bubbles are moving forward exept -1 which is pushed back by the rest
            int[] arr2 = { 100, 1, 2, 3, -1 };
            BubbleSort(arr2);

            Console.WriteLine("Example 4:");
            int[] arr3 = { 100, 1, -2, 2, 3, 500, 100, -10, 400 };
            BubbleSort(arr3);
        }

        private static void BubbleSort(int[] arr)
        {
            Console.WriteLine();
            Console.WriteLine();
            TimeLaps();
            Console.WriteLine(string.Join(", ", arr));
            int temp;
            for (int j = 0; j <= arr.Length - 2; j++)
            {
                for (int i = 0; i <= arr.Length - 2; i++)
                {
                    //compare two numbers
                    if (arr[i] > arr[i + 1])
                    {
                        Console.WriteLine($"Number {arr[i]} is moving forward.");
                        Console.WriteLine(string.Join(", ", arr));

                        TimeLaps();

                        //swap values
                        temp = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = temp;
                    }
                }
            }
            Console.WriteLine("------------Sorted------------");
            Console.WriteLine(string.Join(", ", arr));
            TimeLaps();
            Console.WriteLine();
            Console.WriteLine();
        }

        private static void TimeLaps()
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            Thread.Sleep(1000); //2000 miliseconds=2 seconds
            stopWatch.Stop();
        }
    }
}
