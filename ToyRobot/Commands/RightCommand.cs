using System.Collections.Generic;
using ToyRobot.Enums;
using ToyRobot.Logic;
using ToyRobot.Models;

namespace ToyRobot.Commands
{
    public class RightCommand : AbstractCommand, ICommand
    {
        private readonly IDictionary<Direction, Direction> RightTurns = new Dictionary<Direction, Direction>
        {
            { Direction.NORTH, Direction.EAST },
            { Direction.EAST, Direction.SOUTH },
            { Direction.SOUTH, Direction.WEST },
            { Direction.WEST, Direction.NORTH }
        };

        public RightCommand(string[] parameters) : base(parameters)
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
                Facing = RightTurns[currentPosition.Facing]
            };
        }
    }
}
