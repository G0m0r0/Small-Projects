using System;

namespace bit_at_first_position
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int bitAtPosition1 = 0;
            for (int i = 0; i < n; i++)
            {
                n = n >> 1;
            }
        }
    }
}
