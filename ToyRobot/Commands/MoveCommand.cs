using System.Collections.Generic;
using ToyRobot.Enums;
using ToyRobot.Logic;
using ToyRobot.Models;

namespace ToyRobot.Commands
{
    public class MoveCommand : AbstractCommand, ICommand
    {
        private readonly IDictionary<Direction, int> XCoordChanges = new Dictionary<Direction, int>
        {
            { Direction.NORTH, 0 },
            { Direction.WEST, -1 },
            { Direction.SOUTH, 0 },
            { Direction.EAST, 1 }
        };

        private readonly IDictionary<Direction, int> YCoordChanges = new Dictionary<Direction, int>
        {
            { Direction.NORTH, 1 },
            { Direction.WEST, 0 },
            { Direction.SOUTH, -1 },
            { Direction.EAST, 0 }
        };

        public MoveCommand(string[] parameters) : base(parameters)
        {
        }

        public Position Execute(Position currentPosition, IPositionValidator positionValidator)
        {
            if(currentPosition == null)
            {
                return currentPosition;
            }

            Position newPosition = new Position(currentPosition);
            newPosition.X = currentPosition.X + XCoordChanges[currentPosition.Facing];
            newPosition.Y = currentPosition.Y + YCoordChanges[currentPosition.Facing];

            if (!positionValidator.Validate(newPosition))
            {
                return currentPosition;
            }

            return newPosition;
        }
    }
}
