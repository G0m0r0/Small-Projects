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
            string username="dido", password="12345",a,b;
            int br=0;
            do
            {
                Console.WriteLine("Enter username and password:");
                Console.Write("Username: ");
                a = Console.ReadLine();
                Console.Write("Password: ");
                b = Console.ReadLine();
                br++;
                if (br == 3) { Console.WriteLine("too much wrong atemms"); break;  }
            }while(username !=a && password != b );
            if (br < 3) Console.WriteLine("Corectly");
            Console.ReadLine();
        }
    }
}
