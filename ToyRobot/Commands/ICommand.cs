using ToyRobot.Logic;
using ToyRobot.Models;

namespace ToyRobot.Commands
{
    public interface ICommand
    {
        Position Execute(Position currentPosition, IPositionValidator positionValidator);
    }
}
