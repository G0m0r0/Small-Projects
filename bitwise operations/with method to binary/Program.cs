using System;

namespace with_method_to_binary
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
           // Console.WriteLine(Convert.ToInt32(num,10),2);
            num = num >> 1; 
        }
    }
}
