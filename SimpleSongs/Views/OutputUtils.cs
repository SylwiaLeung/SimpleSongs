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
    }
}
