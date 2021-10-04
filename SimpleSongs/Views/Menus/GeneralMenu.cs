using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleSongs.Views.Menus
{
    public class GeneralMenu
    {
        public void RunMainMenu()
        {
            bool isRunning = true;
            while(isRunning)
            {
                int option = InputUtils.GetUserIntInput();
                switch (option)
                {
                    case 1:
                        Game newGame = new Game();
                        newGame.StartGame();
                        break;
                    case 2:
                        Console.Clear();
                        //HighScore.DisplayScores();
                        break;
                    case 3:
                        Console.Clear();
                        Printer.DisplayRules();
                        break;
                    case 0:
                        running = false;
                        break;
                    default:
                        break;
                }
            }
        }
        
        
    }
}
