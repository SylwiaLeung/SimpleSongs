using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using SimpleSongs.Models;

namespace SimpleSongs.DAL
{
    public class Context : DbContext
    {
        public DbSet<Song> Songs { get; set; }

        public string DbPath { get; private set; }

        public Context()
        {
            DbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Songs.db");
            SaveChanges();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.SeedDatabase();
        }
    }
}
