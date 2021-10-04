using System;

namespace SimpleSongs.Models
{
    public class EmptyTitleException : Exception
    {
        public EmptyTitleException(string message) : base(string.Format("Invalid Title", message)) { }
    }
}
