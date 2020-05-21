using System;
using System.Linq;

namespace p1
{
    class Program
    {
        static void Main(string[] args)
        {
              string sequence = string.Empty;
              string filename = string.Empty;
              switch (args[0])
              {
                  case "-h":
                      d1.Class1.Help();
                     
                      break;
                  case "-g":
                      sequence = d1.Class1.Gen();
                      filename = args[1];
                      Console.WriteLine(sequence);
                      d1.Class1.SaveToFile(sequence, filename);
                      break;
                  case "-v":
                      filename = args[1];
                      sequence = d1.Class1.ReadFromFile(filename);
                      Console.WriteLine(sequence);
                      break;
                  case "-s":
                      filename = args[1];
                      string filenameSorted = args[2];
                      sequence = d1.Class1.ReadFromFile(filename);
                      string sortedNumbers = d1.Class1.Sort(sequence);
                      Console.WriteLine(sortedNumbers);
                      d1.Class1.SaveToFile(sortedNumbers, filenameSorted);
                      break;
              }
        }  
    }
}
