using NUnit.Framework;
using ToyRobot.Commands;
using ToyRobot.Enums;
using ToyRobot.Logic;
using ToyRobot.Models;

namespace ToyRobot.Tests.CommandTests
{
    [TestFixture]
    public class UnsetPositionTests
    {
        [Test]
        public void MoveCommand_WithoutSetCurrentPosition_Returns_UnchangedPosition()
        {
            ICommand moveCommand = new MoveCommand(new string[] { });
            Position currentPosition = null;
            IPositionValidator positionValidator = new PositionValidator(5, 5);

            Position newPosition = moveCommand.Execute(currentPosition, positionValidator);

            Assert.IsNull(newPosition);
        }

        [Test]
        public void LeftCommand_WithoutSetCurrentPosition_Returns_UnchangedPosition()
        {
            ICommand leftCommand = new LeftCommand(new string[] { });
            Position currentPosition = null;
            IPositionValidator positionValidator = new PositionValidator(5, 5);

            Position newPosition = leftCommand.Execute(currentPosition, positionValidator);

            Assert.IsNull(newPosition);
        }

        [Test]
        public void RightCommand_WithoutSetCurrentPosition_Returns_UnchangedPosition()
        {
            ICommand rightCommand = new RightCommand(new string[] { });
            Position currentPosition = null;
            IPositionValidator positionValidator = new PositionValidator(5, 5);

            Position newPosition = rightCommand.Execute(currentPosition, positionValidator);

            Assert.IsNull(newPosition);
        }

        [Test]
        public void PlaceCommand_WithoutSetCurrentPosition_AndValidNewPositon_Returns_PlacedPosition()
        {
            ICommand placeCommand = new PlaceCommand(new string[] {"1", "1", "NORTH"});
            Position currentPosition = null;
            IPositionValidator positionValidator = new PositionValidator(5, 5);

            Position newPosition = placeCommand.Execute(currentPosition, positionValidator);

            Assert.That(newPosition.X == 1);
            Assert.That(newPosition.Y == 1);
            Assert.That(newPosition.Facing == Direction.NORTH);
        }

        [Test]
        public void PlaceCommand_WithoutSetCurrentPosition_AndInvalidNewPositon_Returns_Null()
        {
            ICommand placeCommand = new PlaceCommand(new string[] { "5", "1", "NORTH" });
            Position currentPosition = null;
            IPositionValidator positionValidator = new PositionValidator(5, 5);

            Position newPosition = placeCommand.Execute(currentPosition, positionValidator);

            Assert.IsNull(newPosition);
        }
    }
}
