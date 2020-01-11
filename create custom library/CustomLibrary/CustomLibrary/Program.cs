using Sorts;
using System;

namespace CustomLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rd = new Random();
            int[] numbers = new int[5];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rd.Next(1, 6);
            }

           // Sort.IntArrayBubbleSort(numbers);
           // Sort.IntArrayInsertionSort(numbers);
           // Sort.IntArraySelectionSort(numbers);

            foreach (var num in numbers)
            {
                Console.Write(num+" ");
            }

            Console.WriteLine();

            Console.WriteLine(Sort.IntArrayMin(numbers, 0));
        }
    }
}
