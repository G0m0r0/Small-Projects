using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            string b="";
            Console.Write("Enter decimal digit= ");
            a = int.Parse(Console.ReadLine());
            while (a > 0)
            {
                b += (a % 2).ToString();
                a /= 2;
                Console.WriteLine(b);
            }
            Console.WriteLine("binary code= " + b);
            Console.ReadLine();
           
        }
    }
}
