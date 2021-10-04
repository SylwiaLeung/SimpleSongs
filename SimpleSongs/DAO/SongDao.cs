using System;
using System.Collections.Generic;
using System.Linq;
using SimpleSongs.Models;

namespace SimpleSongs.DAO
{
    public class SongDao : IDao<Song>
    {
        private readonly DbContext dbContext { get; set; }

        public SongDao()
        {
            dbContext = new();
        }

        public void Add(Song instance)
        {
            dbContext.Songs.Attach(instance);
        }

        public void Delete(Song instance)
        {
            dbContext.Songs.Remove(instance);
        }

        public Song Read(Song instance)
        {
            return dbContext.Songs.AsNoTracking().FirstOrDefault(song => song.Title == instance.Title);
        }

        public List<Song> ReadAll()
        {
            return dbContext.Songs.AsNoTracking().ToList();
        }

        public void Save()
        {
            dbContext.SaveChanges();
        }

        public void Update(Song instance)
        {
            dbContext.Songs.Update(instance);
        }
    }
}
