using System.Collections.Generic;
using ToyRobot.Enums;
using ToyRobot.Logic;
using ToyRobot.Models;

namespace ToyRobot.Commands
{
    public class LeftCommand : AbstractCommand, ICommand
    {
        private readonly IDictionary<Direction, Direction> LeftTurns = new Dictionary<Direction, Direction>
        {
            { Direction.NORTH, Direction.WEST },
            { Direction.WEST, Direction.SOUTH },
            { Direction.SOUTH, Direction.EAST },
            { Direction.EAST, Direction.NORTH }
        };

        public LeftCommand(string[] parameters) : base(parameters)
        {
        }

        public Position Execute(Position currentPosition, IPositionValidator positionValidator)
        {
            if (currentPosition == null)
            {
                return currentPosition;
            }

            return new Position(currentPosition)
            {
                Facing = LeftTurns[currentPosition.Facing]
            };
        }
    }
}
