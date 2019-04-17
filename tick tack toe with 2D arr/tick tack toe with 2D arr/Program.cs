using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tick_tack_toe_with_2D_arr
{
    class Program
    {
        static void MatrixOutput(string[,] a)
        {
 
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine();
                    for (int j = 0; j < 3; j++)
                    {
                        Console.Write( " "+ a[j, i]);
                    }
                }
                Console.WriteLine();
        }
        static void MatrixInputA(string[,] a)
        {
                //matrix input
                Console.WriteLine("Player X:");
                Console.Write("Enter coloum i= ");
                int num1 = int.Parse(Console.ReadLine());
                Console.Write("Enter row    j= ");
                int num2 = int.Parse(Console.ReadLine());
                a[num1 - 1, num2 - 1] = "X";
        }
        static void MatrixInputB(string[,] a)
        {

            Console.WriteLine("Player O:");
            Console.Write("Enter coloum i= ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter row    j= ");
            int num2 = int.Parse(Console.ReadLine());
            a[num1-1, num2-1] = "O";
        }
        static void Main(string[] args)
        {
            
            string[,] a = new string[3, 3] { { ".", ".", "." }, { ".", ".", "." }, { ".", ".", "." } };
            Console.WriteLine();
            MatrixOutput(a);
            for (int i = 0; i < 9; i++)
            {    
                if (i % 2 == 0)
                {
                    MatrixInputA(a);
                    MatrixOutput(a);
                    Console.WriteLine();
                }
                else
                {
                    MatrixInputB(a);
                    MatrixOutput(a);
                    Console.WriteLine();
                }
                
            }
        }
    }
}
