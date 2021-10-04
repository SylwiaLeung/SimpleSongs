using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using SimpleSongs.Models;

namespace SimpleSongs.DAL
{
    public static class Seeder
    {
        public static void SeedDatabase(this ModelBuilder builder)
        {
            List<Song> Songs = new()
            {
                new Song()
                {
                    ID = 1,
                    Title = "House Without Windows",
                    Author = "Roy Orbison",
                    AlbumName = "In Dreams",
                    Length = 2.15
                },
                new Song()
                {
                    ID = 2,
                    Title = "In Dreams",
                    Author = "Roy Orbison",
                    AlbumName = "In Dreams",
                    Length = 2.51
                },
                new Song()
                {
                    ID = 3,
                    Title = "Lonely Wine",
                    Author = "Roy Orbison",
                    AlbumName = "In Dreams",
                    Length = 2.57
                },
                new Song()
                {
                    ID = 4,
                    Title = "Fuel",
                    Author = "Metallica",
                    AlbumName = "S&M",
                    Length = 4.36
                },
                new Song()
                {
                    ID = 5,
                    Title = "Master of Puppets",
                    Author = "Metallica",
                    AlbumName = "S&M",
                    Length = 9.34
                },
                new Song()
                {
                    ID = 6,
                    Title = "Mama Said",
                    Author = "Metallica",
                    AlbumName = "Load",
                    Length = 5.20
                },
            };
        }
}
