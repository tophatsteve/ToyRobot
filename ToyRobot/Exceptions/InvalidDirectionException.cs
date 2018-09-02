using System;

namespace ToyRobot.Exceptions
{
    public class InvalidDirectionException : Exception
    {
        public InvalidDirectionException()
        {
        }

        public InvalidDirectionException(string message)
            : base(message)
        {
        }

        public InvalidDirectionException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
