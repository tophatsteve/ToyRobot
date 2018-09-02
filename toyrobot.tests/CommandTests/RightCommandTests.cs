using NUnit.Framework;
using ToyRobot.Commands;
using ToyRobot.Enums;
using ToyRobot.Logic;
using ToyRobot.Models;

namespace ToyRobot.Tests.CommandTests
{
    [TestFixture]
    public class RightCommandTests
    {
        [Test]
        public void RightCommand_CurrentPositionNorth_SetPositionToEast()
        {          
            Position currentPosition = new Position
            {
                Facing = Direction.NORTH,
                X = 0,
                Y = 0
            };
            IPositionValidator positionValidator = new PositionValidator(5, 5);
            ICommand RightCommand = new RightCommand(new string[] { });

            Position newPosition = RightCommand.Execute(currentPosition, positionValidator);

            Assert.That(newPosition.Facing == Direction.EAST);
        }

        [Test]
        public void RightCommand_CurrentPositionEast_SetPositionToSouth()
        {
            Position currentPosition = new Position
            {
                Facing = Direction.EAST,
                X = 0,
                Y = 0
            };
            IPositionValidator positionValidator = new PositionValidator(5, 5);
            ICommand RightCommand = new RightCommand(new string[] { });

            Position newPosition = RightCommand.Execute(currentPosition, positionValidator);

            Assert.That(newPosition.Facing == Direction.SOUTH);
        }

        [Test]
        public void RightCommand_CurrentPositionSouth_SetPositionToWest()
        {
            Position currentPosition = new Position
            {
                Facing = Direction.SOUTH,
                X = 0,
                Y = 0
            };
            IPositionValidator positionValidator = new PositionValidator(5, 5);
            ICommand RightCommand = new RightCommand(new string[] { });

            Position newPosition = RightCommand.Execute(currentPosition, positionValidator);

            Assert.That(newPosition.Facing == Direction.WEST);
        }

        [Test]
        public void RightCommand_CurrentPositionWest_SetPositionToNorth()
        {
            Position currentPosition = new Position
            {
                Facing = Direction.WEST,
                X = 0,
                Y = 0
            };
            IPositionValidator positionValidator = new PositionValidator(5, 5);
            ICommand RightCommand = new RightCommand(new string[] { });

            Position newPosition = RightCommand.Execute(currentPosition, positionValidator);

            Assert.That(newPosition.Facing == Direction.NORTH);
        }
    }
}
