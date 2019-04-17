using System;
using System.Threading;

namespace Tetris_game
{
    class Program
    {
        //setting
        static int tetrisRows = 20;
        static int tetrisCols = 10;
        static int infoCols = 10;
        static int consoleRows = 1 + tetrisRows + 1;
        static int consoleCols = 1 + tetrisCols + 1 + infoCols + 1;

        //state
        static int score = 0;
        static int Frame = 0;
        static int FramesToMoveFigure = 15;
        static bool[,] TetrisField = new bool[tetrisRows, tetrisCols];
        private static bool key;

        static void drawBorder()
        {
            Console.SetCursorPosition(0, 0);
            string line = "╔";
            line += new string('═', tetrisCols);
          // for (int i = 0; i < tetrisCols; i++)
          // {
          //     line += "═";
          // }
            line += "╦";
            line += new string('═', tetrisCols);
            line += "╗";
            Console.Write(line);
            for (int i = 0; i < tetrisRows; i++)
            {
                string middleLine = "║";
                middleLine += new string(' ', tetrisCols);
                middleLine += "║";
                middleLine += new string(' ', tetrisCols);
                middleLine += "║";
                Console.Write(middleLine);
            }
            string endLine = "╚";
            endLine += new string('═', tetrisCols);
            endLine += "╩";
            endLine += new string('═', tetrisCols);
            endLine += "╝";
            Console.Write(endLine);
        }
        static void Write(string text,int row, int col)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(col, row);
            Console.Write(text);

        }
        static void Main(string[] args)
        {
            Console.Title = "Tetris v1.0";
            Console.WindowHeight = consoleRows+1;
            Console.WindowWidth = consoleCols;
            Console.BufferHeight = consoleRows+1;
            Console.BufferWidth = consoleCols;
            Console.CursorVisible = false;
           // drawBorder();
         //   DrawInfo();
            while(true)
            {
                //Read user input
                if (Console.KeyAvailable)
                {
                    var key=Console.ReadKey();
                    if (key.Key == ConsoleKey.Escape)
                    {
                        return;
                        //Enviroment.Exit(0)
                    }
                }                

                //TODO: MoveFigure()

                //TODO: Update the game state
                if(Frame%FramesToMoveFigure==0)
                {
                    score++;
                }
                if()
               // if(collision())
                {
                   // AddCrrentFigureToTetrisField();
                   // CheckForFullLines()
                   //if(lines remove) Score++
                }

                //Draw UI
                drawBorder();
                DrawInfo();
                //TODO: DRAWTetrisField()
                //TODO: DrawCurrentFigure()

                Thread.Sleep(40);

            }
        }

        static void DrawInfo()
        {
            Write("Score:", 1, 3 + tetrisCols);
            Write(score.ToString(), 2, 3 + tetrisCols);

        }
    }
}
