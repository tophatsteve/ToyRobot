using ToyRobot.Logic;
using ToyRobot.Models;

namespace ToyRobot.Commands
{
    public class UnknownCommand : AbstractCommand, ICommand
    {
        public UnknownCommand(string[] parameters) : base(parameters)
        {
        }

        public Position Execute(Position currentPosition, IPositionValidator positionValidator)
        {
            return currentPosition;
        }
    }
}
