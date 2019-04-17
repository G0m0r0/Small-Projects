using System;
using System.Collections.Generic;

namespace bitwise_operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            List<string> numBinary = new List<string>();

            while (num>0)
            {
                numBinary.Add((num % 2).ToString());
                num /= 2;
            }
            numBinary.Reverse();
            Console.WriteLine(string.Join(" ",numBinary));
        }
    }
}
