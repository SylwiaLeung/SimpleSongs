using System;
using SimpleSongs.DAO;
using SimpleSongs.Models;

namespace SimpleSongs.Controllers
{
    public class SongController
    {
        private IDao<Song> SongDao { get; set; }
        public SongController(IDao<Song> songDao)
        {
            SongDao = songDao;
        }

        public Song GetSongByTitle(string title)
        {
            if(string.IsNullOrEmpty(title))
            {
                throw new EmptyTitleException(title);
            }
            else return SongDao.Read(title);
        }

        public void AddNewSong(string title, string author, string album, double length)
        {
            Song song = new()
            {
                Title = title,
                Author = author,
                AlbumName = album,
                Length = length
            };
            SongDao.Add(song);
        }

        public void DisplaySongs()
        {
            OutputUtils.DisplayMany(SongDao.ReadAll());
        }
    }
}
