using NUnit.Framework;
using ToyRobot.Commands;
using ToyRobot.Enums;
using ToyRobot.Logic;
using ToyRobot.Models;

namespace ToyRobot.Tests.CommandTests
{
    [TestFixture]
    public class MoveCommandTests
    {
        [Test]
        public void MoveCommand_FacingNorth_ReturnsPosition_WillIncreaseY_By1()
        {
            Position currentPosition = new Position
            {
                Facing = Direction.NORTH,
                X = 1,
                Y = 1
            };
            IPositionValidator positionValidator = new PositionValidator(5, 5);
            ICommand moveCommand = new MoveCommand(new string[] { });

            Position newPosition = moveCommand.Execute(currentPosition, positionValidator);

            Assert.That(newPosition.X == 1);
            Assert.That(newPosition.Y == 2);
            Assert.That(newPosition.Facing == Direction.NORTH);
        }

        [Test]
        public void MoveCommand_FacingEast_ReturnsPosition_WillIncreaseX_By1()
        {
            Position currentPosition = new Position
            {
                Facing = Direction.EAST,
                X = 1,
                Y = 1
            };
            IPositionValidator positionValidator = new PositionValidator(5, 5);
            ICommand moveCommand = new MoveCommand(new string[] { });

            Position newPosition = moveCommand.Execute(currentPosition, positionValidator);

            Assert.That(newPosition.X == 2);
            Assert.That(newPosition.Y == 1);
            Assert.That(newPosition.Facing == Direction.EAST);
        }

        [Test]
        public void MoveCommand_FacingSouth_ReturnsPosition_WillDecreasedY_By1()
        {
            Position currentPosition = new Position
            {
                Facing = Direction.SOUTH,
                X = 1,
                Y = 1
            };
            IPositionValidator positionValidator = new PositionValidator(5, 5);
            ICommand moveCommand = new MoveCommand(new string[] { });

            Position newPosition = moveCommand.Execute(currentPosition, positionValidator);

            Assert.That(newPosition.X == 1);
            Assert.That(newPosition.Y == 0);
            Assert.That(newPosition.Facing == Direction.SOUTH);
        }

        [Test]
        public void MoveCommand_FacingWest_ReturnsPosition_WillDecreasedX_By1()
        {
            Position currentPosition = new Position
            {
                Facing = Direction.WEST,
                X = 1,
                Y = 1
            };
            IPositionValidator positionValidator = new PositionValidator(5, 5);
            ICommand moveCommand = new MoveCommand(new string[] { });

            Position newPosition = moveCommand.Execute(currentPosition, positionValidator);

            Assert.That(newPosition.X == 0);
            Assert.That(newPosition.Y == 1);
            Assert.That(newPosition.Facing == Direction.WEST);
        }

        [TestCase(0, 2, Direction.WEST)]
        [TestCase(2, 0, Direction.SOUTH)]
        [TestCase(4, 2, Direction.EAST)]
        [TestCase(2, 4, Direction.NORTH)]
        public void MoveCommand_AttemptToMoveOfEdgeOfTable_ReturnsUnchangedPosition(int xPosition, int yPosition, Direction facing)
        {
            Position currentPosition = new Position
            {
                Facing = facing,
                X = xPosition,
                Y = yPosition
            };
            IPositionValidator positionValidator = new PositionValidator(5, 5);
            ICommand moveCommand = new MoveCommand(new string[] { });

            Position newPosition = moveCommand.Execute(currentPosition, positionValidator);

            Assert.That(newPosition.X == currentPosition.X);
            Assert.That(newPosition.Y == currentPosition.Y);
            Assert.That(newPosition.Facing == currentPosition.Facing);
        }
    }
}
