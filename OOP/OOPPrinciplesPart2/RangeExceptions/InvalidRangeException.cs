namespace RangeExceptions
{
    using System;

    public class InvalidRangeException<T> : ArgumentException
    {
        public InvalidRangeException(string message, T start, T end)
            : base(string.Format("{0}: {1} - {2}", message, start, end))
        {

        }
    }
}