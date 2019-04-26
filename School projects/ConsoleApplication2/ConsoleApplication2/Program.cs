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
            System.Random MyRandomGenerator;
            MyRandomGenerator = new System.Random();
            int Distance = 0;
            X = Cat.Location.X + CatXChg;
            Y = Cat.Location.Y + CatYChg;
            Cat.Location = new Point(X, Y);
            X = Mouse.Location.X + MouseXChg;
            Y = Mouse.Location.Y + MouseYChg;
            Mouse.Location = new Point(X, Y);
            Distance = HowFar(50, 150, Mouse.Location.X, Mouse.Location.Y);
            if (Distance < 20) { timer1.Stop(); label1.Text = "Мишката избяга!"; }
            Distance = HowFar(530, 150, Mouse.Location.X, Mouse.Location.Y);
            if (Distance < 20) { timer1.Stop(); label1.Text = "Мишката избяга!"; }
            Distance = HowFar(Cat.Location.X, Cat.Location.Y, Mouse.Location.X, Mouse.Location.Y);
            if (Distance < 40)
            {
                MouseXChg = 0 - MouseXChg;
                MouseYChg = MouseYChg;
            }
            Distance = HowFar(Cat.Location.X, Cat.Location.Y, Mouse.Location.X, Mouse.Location.Y);
            if (Distance < 20) { timer1.Stop(); label1.Text = "Мишката е хваната!"; }
            Distance = HowFar(0, Cat.Location.Y, Cat.Location.X, Cat.Location.Y);
            if (Distance < 20)
            {
                CatXChg = 0 - CatXChg;
                CatYChg = NewChg();
            }
            Distance = HowFar(600, Cat.Location.Y, Cat.Location.X, Cat.Location.Y);
            if (Distance < 20)
            {
                CatXChg = 0 - CatXChg;
                CatYChg = NewChg();
            }
            Distance = HowFar(Cat.Location.X, 0, Cat.Location.X, Cat.Location.Y);
            if (Distance < 20)
            {
                CatYChg = 0 - CatYChg;
                CatXChg = NewChg();
            }
            Distance = HowFar(Cat.Location.X, 300, Cat.Location.X, Cat.Location.Y);
            if (Distance < 20)
            {
                CatYChg = 0 - CatYChg;
                CatXChg = NewChg();
            }
            Distance = HowFar(0, Mouse.Location.Y, Mouse.Location.X, Mouse.Location.Y);
            if (Distance < 20)
            {
                MouseXChg = 0 - MouseXChg;
                MouseYChg = NewChg();
            }
            Distance = HowFar(600, Mouse.Location.Y, Mouse.Location.X, Mouse.Location.Y);
            if (Distance < 20)
            {
                MouseXChg = 0 - MouseXChg;
                MouseYChg = NewChg();
            }
            Distance = HowFar(Mouse.Location.X, 0, Mouse.Location.X, Mouse.Location.Y);
            if (Distance < 20)
            {
                MouseYChg = 0 - MouseYChg;
                MouseXChg = NewChg();
            }
            Distance = HowFar(Mouse.Location.X, 300, Mouse.Location.X, Mouse.Location.Y);
            if (Distance < 20)
            {
                MouseYChg = 0 - MouseYChg;
                MouseXChg = NewChg();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Random MyRandomGenerator;
            MyRandomGenerator = new System.Random();
            X = MyRandomGenerator.Next(50, 500);
            Y = MyRandomGenerator.Next(50, 250);
            Cat.Location = new Point(X, Y);
            CatXChg = NewChg();
            CatYChg = NewChg();
            X = MyRandomGenerator.Next(50, 500);
            Y = MyRandomGenerator.Next(50, 250);
            Mouse.Location = new Point(X, Y);
            MouseXChg = NewChg();
            MouseYChg = NewChg();
            label1.Text = "";
            timer1.Start();
        }

        private int HowFar(int FirstX, int FirstY, int SecondX, int SecondY)
        {
            int DistanceBetween = 0;
            DistanceBetween = Convert.ToInt16(Math.Sqrt(Convert.ToDouble((FirstX - SecondX) * (FirstX - SecondX)) + Convert.ToDouble((FirstY - SecondY) * (FirstY - SecondY))));
            return DistanceBetween;
        }

        private int NewChg()
        {
            int Change;
            System.Random MyRandomGenerator;
            MyRandomGenerator = new System.Random();
            int RunNum = 0;
            RunNum = MyRandomGenerator.Next(0, 4);
            if (RunNum == 0) { Change = -7; }
            else
            {
                if (RunNum == 1) { Change = -4; }
                else
                {
                    if (RunNum == 2) { Change = 7; }
                    else { Change = 4; }
                }
            }
            return Change;
        }
    }
}
    }
}
