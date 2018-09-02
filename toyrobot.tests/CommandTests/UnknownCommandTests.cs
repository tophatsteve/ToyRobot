using NUnit.Framework;
using ToyRobot.Commands;
using ToyRobot.Enums;
using ToyRobot.Logic;
using ToyRobot.Models;

namespace ToyRobot.Tests.CommandTests
{
    [TestFixture]
    public class UnknownCommandTests
    {
        [Test]
        public void UnknownCommand_Returns_UnchangedPosition()
        {
            Position currentPosition = new Position
            {
                Facing = Direction.NORTH,
                X = 0,
                Y = 0
            };
            IPositionValidator positionValidator = new PositionValidator(5, 5);
            ICommand unknownCommand = new UnknownCommand(new string[] { });

            Position newPosition = unknownCommand.Execute(currentPosition, positionValidator);

            Assert.That(newPosition.X == currentPosition.X);
            Assert.That(newPosition.Y == currentPosition.Y);
            Assert.That(newPosition.Facing == currentPosition.Facing);
        }
    }
}
