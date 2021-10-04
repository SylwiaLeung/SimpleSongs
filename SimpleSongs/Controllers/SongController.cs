using System;
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
            Song song = SongDao.Read(title);
            if (song == null)
            {
                throw new ArgumentException();
            }
            else return song;
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
            List<Song> listOfSongs = SongDao.ReadAll();
            if (listOfSongs == null)
            {
                throw new ArgumentException();
            }
            else OutputUtils.DisplayMany(listOfSongs);

        }

        public List<Song> SortByTitles()
        {
            List<Song> listOfSongs = SongDao.ReadAll().OrderByDescending(song => song.Title).ToList();
            if (listOfSongs == null)
            {
                throw new ArgumentException();
            }
            else return listOfSongs;
        }

        public void DeleteSong(Song songToDelete)
        {
            SongDao.Delete(songToDelete);
            SongDao.Save();
        }
    }
}
