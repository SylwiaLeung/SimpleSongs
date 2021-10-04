using System;

namespace SimpleSongs.Models
{
    public class EmptyTitleException : Exception
    {
        public EmptyTitleException(string title) : base(string.Format("Invalid Title", title)) { }
    }
}
