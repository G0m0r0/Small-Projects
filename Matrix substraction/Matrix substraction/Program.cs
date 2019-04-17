using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix_substraction
{
    class Program
    {
        static void InputMatrix(int[,] a,int n)
        {
            for (int j = 0; j < n; j++)
            {       
                for (int i = 0; i < n; i++)
                    a[i, j] = int.Parse(Console.ReadLine());
            }
        }
        static void Main(string[] args)
        {
            Console.Write("N= "); 
            int n = int.Parse(Console.ReadLine());
            int[ , ] a = new int[n,n];
            int[ , ] b = new int[n,n];
            Console.WriteLine("Matrix A:");
            InputMatrix(a, n);

            Console.WriteLine("Matrix B:");
            InputMatrix(b, n);
    
           Console.WriteLine("Matrix A+B");
           for (int j= 0; j < n; j++)
           {
               Console.WriteLine();
                for (int i = 0; i < n; i++)
                {
                    a[i, j] += b[i, j];
                    Console.Write($"{a[i, j]} ");
                }
           }
            Console.WriteLine();
        }
    }
}
