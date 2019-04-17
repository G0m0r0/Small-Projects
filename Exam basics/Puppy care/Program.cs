using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puppy_care
{
    class Program
    {
        static void Main(string[] args)
        {
            int foodKg = int.Parse(Console.ReadLine());
            foodKg *= 1000;
            string operation = Console.ReadLine();
            int foodGr = 0;
            while(operation!="Adopted")
            {
                foodGr += int.Parse(operation);
                operation = Console.ReadLine();
            }
            if (foodGr <= foodKg) Console.WriteLine("Food is enough! Leftovers: {0} grams.",Math.Abs( foodGr-foodKg));
            else Console.WriteLine("Food is not enough. You need {0} grams more.",Math.Abs( foodKg-foodGr));
        }
    }
}
