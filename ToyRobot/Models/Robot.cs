using ToyRobot.Commands;
using ToyRobot.Logic;

namespace ToyRobot.Models
{
    public class Robot : IRobot
    {
        private readonly ICommandParser _commandParser;
        private readonly IPositionValidator _positionValidator;
        private Position _position;

        public Robot(ICommandParser commandParser, IPositionValidator positionValidator)
        {
            _commandParser = commandParser;
            _positionValidator = positionValidator;
            _position = null;
        }

        public void ExecuteCommand(string commandInput)
        {
            ICommand command = _commandParser.Parse(commandInput);
            _position = command.Execute(_position, _positionValidator);
        }
    }
}
