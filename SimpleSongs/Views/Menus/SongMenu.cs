using System;
using SimpleSongs.Controllers;
using SimpleSongs.Models;

namespace SimpleSongs.Views
{
    public class SongMenu
    {
        private SongController SongController { get; set; }
        public SongMenu(SongController songController)
        {
            SongController = songController;
        }
        public void AddNewSong()
        {
            string title = InputUtils.GetUserStringInput("Please insert the title: ");
            string author = InputUtils.GetUserStringInput("Please insert the author: ");
            string album = InputUtils.GetUserStringInput("Please insert the album: ");
            double length = InputUtils.GetUserDoubleInput("Please insert duration of the song: ");
            if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(author) || double.IsNegative(length))
            {
                AddNewSong();
            }
            else SongController.AddNewSong(title, author, album, length);
        }

        public void DeleteSong()
        {
            string title = InputUtils.GetUserStringInput("Please provide the title of the song you want to delete: ");
            if (string.IsNullOrEmpty(title))
            {
                DeleteSong();
            }
            else
            {
                var songToDelete = SongController.GetSongByTitle(title);
                if (songToDelete == null)
                {
                    OutputUtils.DisplayMessage("There are no songs under such title in the database");
                }
                else SongController.DeleteSong(songToDelete);
            }
        }

        public void DisplayAllSongs()
        {
            SongController.DisplaySongs();
        }

        public void DisplaySongsByTitles()
        {
            OutputUtils.DisplayMany(SongController.SortByTitles());
        }

        public void FindSongByTitle()
        {
            string title = InputUtils.GetUserStringInput("Please provide the title of the song you want to find: ");
            if (string.IsNullOrEmpty(title))
            {
                throw new EmptyTitleException(title);
            }
            else Console.WriteLine(SongController.GetSongByTitle(title).ToString());
        }
    }
}
