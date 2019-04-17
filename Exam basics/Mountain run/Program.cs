using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mountain_run
{
    class Program
    {
        static void Main(string[] args)
        {
            double recordSeconds = double.Parse(Console.ReadLine());
            double distanceMeter = double.Parse(Console.ReadLine());
            double sForMeter = double.Parse(Console.ReadLine());
            //50m 30sec slower
            //math floor
            double neededSec = distanceMeter * sForMeter + (Math.Floor(distanceMeter / 50) )* 30;
           // Console.WriteLine(neededSec);
            if (neededSec < recordSeconds) Console.WriteLine("Yes! The new record is {0:f2} seconds.",neededSec);
            else Console.WriteLine("No! He was {0:f2} seconds slower.",Math.Abs(recordSeconds-neededSec));
        }
    }
}
