using System;
using System.Collections.Generic;
using SimpleSongs.Models;

namespace SimpleSongs.DAO
{
    public class FakeSongDao : IDao<Song>
    {
        public void Add(Song instance)
        {
            Console.WriteLine("Added");
        }

        public void Delete(Song instance)
        {
            Console.WriteLine("Deleted");
        }

        public Song Read(string title)
        {
            return null;
        }

        public List<Song> ReadAll()
        {
            return null;
        }

        public void Save()
        {
            Console.WriteLine("Saved");
        }

        public void Update(Song instance)
        {
            Console.WriteLine("Updated");
        }
    }
}
