using System;
using SimpleSongs.Controllers;
using SimpleSongs.DAO;

namespace SimpleSongs
{
    class Program
    {
        static void Main(string[] args)
        {
            SongController songController = new(new SongDao());
            songController.DisplaySongs();
        }
    }
}
