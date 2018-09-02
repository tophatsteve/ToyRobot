using System;

namespace ToyRobot.Exceptions
{
    public class InvalidXPostionException : Exception
    {
        public InvalidXPostionException()
        {
        }

        public InvalidXPostionException(string message)
            : base(message)
        {
        }

        public InvalidXPostionException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
