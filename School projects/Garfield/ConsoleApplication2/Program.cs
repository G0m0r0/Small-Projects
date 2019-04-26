using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading.Tasks;


namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Money$ that john gives to garfield= ");
            float money= float.Parse(Console.ReadLine());
            Console.Write("exchange rate= ");
            float rate = float.Parse(Console.ReadLine());
            Console.Write("Pizza price= ");
            float pizza = float.Parse(Console.ReadLine());
            Console.Write("Lasagna price= ");
            float lasagna = float.Parse(Console.ReadLine());
            Console.Write("Sandwich price= ");
            float sandwich = float.Parse(Console.ReadLine());
            Console.Write("Pizza quantity= ");
            int pizzaq = int.Parse(Console.ReadLine());
            Console.Write("Lasagna quantity= ");
            int lasagnaq = int.Parse(Console.ReadLine());
            Console.Write("Sandwich quantity= ");
            int sandwichq = int.Parse(Console.ReadLine());
            
            pizza /= rate;
            lasagna /= rate;
            sandwich /= rate;
            float price;
            price = pizza * pizzaq + sandwich * sandwichq + lasagna * lasagnaq;
            if (money >= price) Console.WriteLine("Garfield is well fed, John is awesome. Money left: ${0}.", System.Math.Round(money-price, 2));
            else Console.WriteLine("Garfield is hungry. John is a badass. Money needed: ${0}.", System.Math.Round(price-money, 2));
            Console.ReadLine();
           
        }
    }
}
