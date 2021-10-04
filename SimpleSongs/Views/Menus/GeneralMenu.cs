using SimpleSongs.Controllers;
using SimpleSongs.DAO;

namespace SimpleSongs.Views.Menus
{
    public static class GeneralMenu
    {
        public static void RunMainMenu()
        {
            OutputUtils.DisplayWelcomeMessage();
            SongMenu songMenu = new(new SongController(new SongDao()));
            bool isRunning = true;
            while(isRunning)
            {
                OutputUtils.DisplayMenuOptions();
                int option = InputUtils.GetUserOption(0, 5);
                switch (option)
                {
                    case 1:
                        songMenu.DisplayAllSongs();
                        OutputUtils.GoBackToMainMenu();
                        break;
                    case 2:
                        songMenu.DisplaySongsByTitles();
                        OutputUtils.GoBackToMainMenu();
                        break;
                    case 3:
                        songMenu.DeleteSong();
                        OutputUtils.GoBackToMainMenu();
                        break;
                    case 4:
                        songMenu.FindSongByTitle();
                        OutputUtils.GoBackToMainMenu();
                        break;
                    case 5:
                        songMenu.AddNewSong();
                        OutputUtils.GoBackToMainMenu();
                        break;
                    case 0:
                        isRunning = false;
                        break;
                    default:
                        break;
                }
            }
        }
        
        
    }
}
