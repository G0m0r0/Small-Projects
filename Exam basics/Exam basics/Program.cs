using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_basics
{
    class Program
    {
        static void Main(string[] args)
        {
            int brcustomers = int.Parse(Console.ReadLine());
            int brkarbins = int.Parse(Console.ReadLine());
            int brropes = int.Parse(Console.ReadLine());
            int brpickles = int.Parse(Console.ReadLine());
            double sum = (brkarbins * 36 + brropes * 3.6 + brpickles * 19.8)*brcustomers;
            double finalSum = sum * 0.2 + sum;
            Console.WriteLine($"{(finalSum):f2}");
        }
    }
}
