using System;
using System.Linq;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6 };

            Console.WriteLine(string.Join(" ",arr.Where(x=>x%3==0)));
            //test
        }
    }
}
