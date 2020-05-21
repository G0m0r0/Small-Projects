using System;
using System.Linq;

namespace d1
{
    public class Class1
    {
        public static string Sort(string sequence)
        {
            int[] sortedArray = sequence.Split(',').Select(x => x.Trim()).Select(int.Parse).ToArray();

            Array.Sort(sortedArray);

            return string.Join(", ", sortedArray);
        }

        public static string ReadFromFile(string filename)
        {
            string sequence = System.IO.File.ReadAllText($"D:\\{filename}");

            return sequence;
        }

        public static void SaveToFile(string sequence, string filename)
        {
            using (System.IO.StreamWriter file =
             new System.IO.StreamWriter($"D:\\{filename}"))
            {
                file.WriteLine(sequence);
            }
        }

        public static string Gen()
        {
            string numbers = string.Empty;
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                if (i == 9)
                {
                    numbers += rnd.Next(0, 100).ToString();
                    break;
                }
                numbers += rnd.Next(0, 100).ToString() + ", ";
            }

            return numbers;
        }

        public static void Help()
        {
            Console.WriteLine("-g (file name) to generate random numbers.");
            Console.WriteLine("-v (file name) to display the random numbers");
            Console.WriteLine("-s (file name 1) (file name 2) read numbers from file 1, sort and save them to file 2");
        }
    }
}

