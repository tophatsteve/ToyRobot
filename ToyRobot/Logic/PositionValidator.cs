using ToyRobot.Models;

namespace ToyRobot.Logic
{
    public class PositionValidator : IPositionValidator
    {
        private int _minimumX;
        private int _maximumX;
        private int _minimumY;
        private int _maximumY;

        public PositionValidator(int length, int width)
        {
            _minimumX = 0;
            _maximumX = length - 1;
            _minimumY = 0;
            _maximumY = width - 1;
        }

        public bool Validate(Position position)
        {
            return position != null &&
                   position.X >= _minimumX &&
                   position.X <= _maximumX &&
                   position.Y >= _minimumY &&
                   position.Y <= _maximumY;
        }
    }
}
