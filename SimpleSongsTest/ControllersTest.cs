using System;
using NUnit.Framework;
using SimpleSongs.Controllers;
using SimpleSongs.DAO;
using SimpleSongs.Models;

namespace SimpleSongsTest
{
    [TestFixture]
    public class Tests
    {
        SongController SongController { get; set; }

        [SetUp]
        public void SetUp()
        {
            IDao<Song> FakeSongDao = new FakeSongDao();
            SongController = new(FakeSongDao);
        }

        [Test]
        public void DatabaseRecordEmpty_ThrowsArgumentException()
        {
            //arrange
            string title = "Non-existant";

            //assert
            Assert.Throws<ArgumentException>(() => SongController.GetSongByTitle(title));
        }

        [Test]
        public void DatabaseAllRecordsEmpty_ThrowsArgumentException()
        {
            //assert
            Assert.Throws<ArgumentException>(() => SongController.DisplaySongs());
        }

        [Test]
        public void ListSortedByTitleEmpty_ThrowsArgumentException()
        {
            //assert
            Assert.Throws<ArgumentException>(() => SongController.DisplaySongs());
        }

    }
}