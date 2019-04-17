using System;

namespace tetris
{
    class Program
    {
        static void MyMethod(string text,ConsoleColor color
            )
        {
            Console.ForegroundColor = color;
            Console.WriteLine(text);
            Console.ResetColor();
        }
        static void Main(string[] args)
        {
            string myText = Console.ReadLine();
            MyMethod(myText,ConsoleColor.Magenta);
            MyMethod("text", ConsoleColor.Yellow);
        }
    }
}
