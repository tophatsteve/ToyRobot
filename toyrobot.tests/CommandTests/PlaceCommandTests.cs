using NUnit.Framework;
using ToyRobot.Commands;
using ToyRobot.Enums;
using ToyRobot.Logic;
using ToyRobot.Models;

namespace ToyRobot.Tests.CommandTests
{
    [TestFixture]
    public class PlaceCommandTests
    {
        [Test]
        public void PlaceCommand_AndValidNewPositon_Returns_PlacedPosition()
        {
            Position currentPosition = new Position
            {
                Facing = Direction.NORTH,
                X = 1,
                Y = 1
            };
            IPositionValidator positionValidator = new PositionValidator(5, 5);
            ICommand placeCommand = new PlaceCommand(new string[] { "3", "4", "SOUTH" });
            
            Position newPosition = placeCommand.Execute(currentPosition, positionValidator);

            Assert.That(newPosition.X == 3);
            Assert.That(newPosition.Y == 4);
            Assert.That(newPosition.Facing == Direction.SOUTH);
        }

        [Test]
        public void PlaceCommand_AndInvalidNewPositon_Returns_UnchangedPosition()
        {
            Position currentPosition = new Position
            {
                Facing = Direction.NORTH,
                X = 1,
                Y = 1
            };
            IPositionValidator positionValidator = new PositionValidator(5, 5);
            ICommand placeCommand = new PlaceCommand(new string[] { "1", "5", "SOUTH" });

            Position newPosition = placeCommand.Execute(currentPosition, positionValidator);

            Assert.That(newPosition.X == 1);
            Assert.That(newPosition.Y == 1);
            Assert.That(newPosition.Facing == Direction.NORTH);
        }
    }
}
