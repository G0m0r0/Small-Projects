using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace safe_password_generator
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int maxPass = int.Parse(Console.ReadLine());
            char first = '#';
            char second = '@';
            int tirth = 1;
            int forth = 1;
           // char fifth = '@';
            //char sixth = '#';
            for (int i = 0; i < maxPass; i++)
            {      
                Console.Write($"{first}{second}{tirth}{forth}{second}{first}");
                Console.Write("|");
                if (tirth == a && forth == b) break;
                first++;
                second++;
                if (forth == b) { forth = 0; tirth++; }
                forth++;
                //fifth++;
               // sixth++;
                if (first > 55) first = '#';
                if (second > 96) second = '@';
            }
        }
    }
}
