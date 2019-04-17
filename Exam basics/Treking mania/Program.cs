using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treking_mania
{
    class Program
    {
        static void Main(string[] args)
        {
            int groups = int.Parse(Console.ReadLine());
            int numPeople = 0;
            int sumPeople = 0;
            double musala = 0, monblan = 0, kilimandjaro = 0, k2 = 0, everest = 0;
            for (int i = 0; i < groups; i++)
            {
                numPeople = int.Parse(Console.ReadLine());
                sumPeople += numPeople;
                if (numPeople > 0 && numPeople <= 5) musala += numPeople;
                else if (numPeople > 5 && numPeople <= 12) monblan += numPeople;
                else if (numPeople >= 13 && numPeople <= 25) kilimandjaro += numPeople;
                else if (numPeople >= 26 && numPeople <= 40) k2 += numPeople;
                else if (numPeople >= 41) everest += numPeople;
            }
            Console.WriteLine($"{(musala/sumPeople*100):f2}%");
            Console.WriteLine($"{(monblan / sumPeople * 100):f2}%");
            Console.WriteLine($"{(kilimandjaro / sumPeople * 100):f2}%");
            Console.WriteLine($"{(k2/ sumPeople * 100):f2}%");
            Console.WriteLine($"{(everest / sumPeople * 100):f2}%");

        }
    }
}
