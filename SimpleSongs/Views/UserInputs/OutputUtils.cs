using System;
using System.Collections.Generic;
using SimpleSongs.Models;

namespace SimpleSongs.Views
{
    public static class OutputUtils
    {
        public static void DisplayMany(List<Song> listToDisplay)
        {
            foreach (Song instance in listToDisplay)
            {
                Console.WriteLine(instance.ToString());
            }
        }

        public static void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }

        public static void DisplayMenuOptions()
        {
            Console.Clear();
            Console.WriteLine(
                "[1] Display all songs\n" +
                "[2] Display songs ordered by titles\n" +
                "[3] Delete a song\n" +
                "[4] Find a song\n" +
                "[5] Add a new song\n" +
                "[0] Exit");
        }

        public static void GoBackToMainMenu()
        {
            Console.WriteLine("Press any key to go back to the main menu.");
            Console.ReadKey();
        }

        public static void DisplayWelcomeMessage()
        {
            Console.WriteLine("Welcome to the Simple Songs app! Enjoy the simplicity!");
        }
    }
}
