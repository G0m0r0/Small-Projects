using System;

namespace Einstein_s_riddle
{
    class Program
    {
        static string[] houses = { "Red", "Green", "Yellow ", " White", "Blue" };
        static string[] pets = { "Dog", "Cat", "Bird", "Horse", "Fish" };
        static string[] nationalities = { "Brit", "Swede", "Dane", "Norwegian", "German" };
        static string[] cigarettes = { "Blend", "Prince", "Dunhill", "BlueMaster", "PullMall" };
        static string[] drinks = { "Tea", "Coffee", "Milk", "Beer", "Water" };
        static string[] hints = new string[15];

        static void Main(string[] args)
        {
            Random rand = new Random();
            Shuffle(rand);
            GenerateHints();
        }

        private static void GenerateHints()
        {
            hints[0] = $"the {nationalities[2]} lives in the {houses[2]} house";
            hints[1] = $"the {nationalities[4]} keeps {pets[4]} as pets";
            hints[2] = $" ";
            hints[3] = $" ";
            hints[4] = $" ";
            hints[5] = $" ";
            hints[6] = $" ";
            hints[7] = $" ";
            hints[8] = $" ";
            hints[9] = $" ";
            hints[10] = $" ";
            hints[11] = $" ";
            hints[12] = $" ";
            hints[13] = $" ";
            hints[14] = $" ";

        }

        private static void Shuffle(Random rand)
        {
            for (int i = 0; i < 5; i++)
            {
                //shuffle houses
                int randomHouses = i + rand.Next(0, houses.Length - i);
                Swap(i, randomHouses, houses);
                int randomPet = i + rand.Next(0, pets.Length - i);
                Swap(i, randomPet, pets);
                int randomNationality = i + rand.Next(0, nationalities.Length - i);
                Swap(i, randomNationality, nationalities);
                int randomCigarettes = i + rand.Next(0, cigarettes.Length - i);
                Swap(i, randomCigarettes, cigarettes);
                int randomDrinks = i + rand.Next(0, drinks.Length - i);
                Swap(i, randomDrinks, drinks);
            }

        }

        static void Swap(int i, int randomObject, string[] strArray)
        {
            string swap = strArray[i];
            strArray[i] = strArray[randomObject];
            strArray[randomObject] = swap;
        }
    }
}
