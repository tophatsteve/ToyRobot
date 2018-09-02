using NUnit.Framework;
using ToyRobot.Commands;
using ToyRobot.Enums;
using ToyRobot.Logic;
using ToyRobot.Models;

namespace ToyRobot.Tests.CommandTests
{
    [TestFixture]
    public class LeftCommandTests
    {
        [Test]
        public void LeftCommand_CurrentPositionNorth_SetPositionToWest()
        {
            Position currentPosition = new Position
            {
                Facing = Direction.NORTH,
                X = 0,
                Y = 0
            };
            IPositionValidator positionValidator = new PositionValidator(5, 5);
            ICommand leftCommand = new LeftCommand(new string[] { });

            Position newPosition = leftCommand.Execute(currentPosition, positionValidator);

            Assert.That(newPosition.Facing == Direction.WEST);
        }

        [Test]
        public void LeftCommand_CurrentPositionWest_SetPositionToSouth()
        {
            Position currentPosition = new Position
            {
                Facing = Direction.WEST,
                X = 0,
                Y = 0
            };
            IPositionValidator positionValidator = new PositionValidator(5, 5);
            ICommand leftCommand = new LeftCommand(new string[] { });

            Position newPosition = leftCommand.Execute(currentPosition, positionValidator);

            Assert.That(newPosition.Facing == Direction.SOUTH);
        }

        [Test]
        public void LeftCommand_CurrentPositionSouth_SetPositionToEast()
        {
            Position currentPosition = new Position
            {
                Facing = Direction.SOUTH,
                X = 0,
                Y = 0
            };
            IPositionValidator positionValidator = new PositionValidator(5, 5);
            ICommand leftCommand = new LeftCommand(new string[] { });

            Position newPosition = leftCommand.Execute(currentPosition, positionValidator);

            Assert.That(newPosition.Facing == Direction.EAST);
        }

        [Test]
        public void LeftCommand_CurrentPositionEast_SetPositionToNorth()
        {
            Position currentPosition = new Position
            {
                Facing = Direction.EAST,
                X = 0,
                Y = 0
            };
            IPositionValidator positionValidator = new PositionValidator(5, 5);
            ICommand leftCommand = new LeftCommand(new string[] { });

            Position newPosition = leftCommand.Execute(currentPosition, positionValidator);

            Assert.That(newPosition.Facing == Direction.NORTH);
        }
    }
}
