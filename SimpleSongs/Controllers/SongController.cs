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
    }
}
