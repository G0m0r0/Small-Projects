using System;

namespace place_of_showing
{
    class Program
    {
        static void placement(string name, int row,int col)
        {
            Console.Title = "Tetris v1.0";


            Console.SetCursorPosition(col,row);
            Console.WriteLine(name);

        }
        static void Main(string[] args)
        {
            placement("name",10,10);
        }
    }
}
