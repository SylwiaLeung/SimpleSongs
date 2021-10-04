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
            double input = Double.Parse(Console.ReadLine().Trim());
            return input;
        }

        public static int GetUserIntInput(string message)
        {
            Console.WriteLine(message);
            int input = Int32.Parse(Console.ReadLine().Trim());
            return input;
        }
    }
}
