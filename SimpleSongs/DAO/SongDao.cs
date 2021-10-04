﻿using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using SimpleSongs.DAL;
using SimpleSongs.Models;

namespace SimpleSongs.DAO
{
    public class SongDao : IDao<Song>
    {
        private Context DbContext { get; set; }

        public SongDao()
        {
            DbContext = new();
        }

        public void Add(Song instance)
        {
            DbContext.Songs.Attach(instance);
        }

        public void Delete(Song instance)
        {
            DbContext.Songs.Remove(instance);
        }

        public Song Read(string title)
        {
            return DbContext.Songs.AsNoTracking().FirstOrDefault(song => song.Title == title);
        }

        public List<Song> ReadAll()
        {
            return DbContext.Songs.AsNoTracking().ToList();
        }

        public void Save()
        {
            DbContext.SaveChanges();
        }

        public void Update(Song instance)
        {
            DbContext.Songs.Update(instance);
        }
    }
}
