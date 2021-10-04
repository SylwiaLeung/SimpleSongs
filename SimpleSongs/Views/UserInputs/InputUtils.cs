using System;

namespace SimpleSongs.Views
{
    public static class InputUtils
    {
        public static string GetUserStringInput(string message)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine().Trim();
            return input;
        }

        public static double GetUserDoubleInput(string message)
        {
            Console.WriteLine(message);
            double input = Convert.ToDouble(Console.ReadLine().Trim());
            return input;
        }

        public static int GetUserIntInput(string message)
        {
            Console.WriteLine(message);
            int input = Int32.Parse(Console.ReadLine().Trim());
            return input;
        }

        public static int GetUserOption(int min, int max)
        {
            Console.WriteLine($"Please choose an option between {min} and {max}.");
            int number;
            while (!Int32.TryParse(Console.ReadLine(), out number) || number > max || number < min)
            {
                Console.WriteLine($"Number must be between {min} and {max}.");
            }

            return number;
        }
    }
}
