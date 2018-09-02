using System;

namespace ToyRobot.Exceptions
{
    public class InvalidYPositionException : Exception
    {
        public InvalidYPositionException()
        {
        }

        public InvalidYPositionException(string message)
            : base(message)
        {
        }

        public InvalidYPositionException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
