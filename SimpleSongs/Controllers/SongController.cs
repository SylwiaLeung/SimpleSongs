using System.Collections.Generic;
using System.Linq;
using SimpleSongs.DAO;
using SimpleSongs.Models;
using SimpleSongs.Views;

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
            SongDao.Save();
        }

        public void DisplaySongs()
        {
            OutputUtils.DisplayMany(SongDao.ReadAll());
        }

        public List<Song> SortByTitles()
        {
            return SongDao.ReadAll().OrderByDescending(song => song.Title).ToList();
        }

        public void DeleteSong(Song songToDelete)
        {
            SongDao.Delete(songToDelete);
            SongDao.Save();
        }
    }
}
