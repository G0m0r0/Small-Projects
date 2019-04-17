using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ski_trip
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysStaying = int.Parse(Console.ReadLine());
            string room = Console.ReadLine();
            string postivNegative = Console.ReadLine();
            double money = 0;
            daysStaying--;
            if(room=="room for one person")
            {
                if(daysStaying<10)
                {
                    money = daysStaying * 18;
                }
                if(daysStaying>=10&&daysStaying<=15)
                {
                    money = daysStaying * 18;
                }
                if(daysStaying>15)
                {
                    money = daysStaying * 18;
                }
            }
            if (room == "apartment")
            {
                if (daysStaying < 10)
                {
                    money=(daysStaying*25)*0.7;
                }
                if (daysStaying >= 10 && daysStaying <= 15)
                {
                    money = (daysStaying * 25) * 0.65;
                }
                if (daysStaying > 15)
                {
                    money = (daysStaying * 25) * 0.5;
                }
            }
            if (room == "president apartment")
            {
                if (daysStaying < 10)
                {
                    money = (daysStaying * 35) * 0.9;
                }
                if (daysStaying >= 10 && daysStaying <= 15)
                {
                    money = (daysStaying * 35) * 0.85;
                }
                if (daysStaying > 15)
                {
                    money = (daysStaying * 35) * 0.8;
                }
            }
            double finalMoney = 0;
            if (postivNegative == "positive") finalMoney = money * 0.25 + money;
            else finalMoney = money * 0.9;
            Console.WriteLine($"{(finalMoney):f2}");
        }
    }
}
