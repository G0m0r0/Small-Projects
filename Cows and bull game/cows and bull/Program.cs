using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cows_and_bull
{
    class Program
    {
        static void inputFourDigit(ref string num1)
        {
            do
            {
                num1 = Console.ReadLine();
                if (num1.Length != 4)
                    Console.Write("Your number is not in correct form, please enter again!\nNum=  ");
                else
                {
                    if (!fourDigit(num1))
                    {
                        Console.Write("There is same symbol, please enter again integer!\nNum= ");
                        num1 = string.Empty;
                        continue;
                    }
                }
            } while (num1.Length != 4);
        }
        static bool fourDigit(string num)
        {
            for (int i = 0; i <4 ; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (num[i] == num[j])
                    {
                        if (i == j) continue;
                        return false;
                    }
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            string num1 = string.Empty,
                   num2 = string.Empty;  
            Console.Write("Searched number:\nNum=  ");
            inputFourDigit(ref num1);
            Console.WriteLine();
            Console.Clear();

            int brcows = 0;
            int brbulls = 0;
            do
            {
                 brcows = 0;
                 brbulls = 0;
                Console.Write("Enter searched number:\nNum=  ");
                inputFourDigit(ref num2);
                Console.WriteLine();
                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {          
                        if (num1[i] == num2[j])
                        {
                            if (i == j) brbulls++;
                            else brcows++;
                        }                       
                    }                  
                }

                if (brbulls==0&&brcows==0)
                    Console.WriteLine("You dont have matches!");
                else
                {
                    Console.WriteLine($"{brbulls} Bulls | {brcows} Cows");
                }
                Console.WriteLine();

            } while (brbulls != 4);
            if(brbulls==4) Console.WriteLine("You win four bulls!");
        }
    }
}
