using ToyRobot.Models;

namespace ToyRobot.Logic
{
    public interface IPositionValidator
    {
        bool Validate(Position position);
    }
}
