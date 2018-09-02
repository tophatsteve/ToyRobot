using NUnit.Framework;
using ToyRobot.Enums;
using ToyRobot.Logic;
using ToyRobot.Models;

namespace ToyRobot.Tests.LogicTests
{
    [TestFixture]
    public class PositionValidatorTests
    {
        [TestCase(0, 0)]
        [TestCase(4, 4)]
        [TestCase(2, 2)]
        [TestCase(0, 4)]
        [TestCase(4, 0)]
        public void Valid_Positions_Return_True(int xPosition, int yPosition)
        {
            int tableLength = 5;
            int tableWidth = 5;
            Position currentPosition = new Position
            {
                Facing = Direction.NORTH,
                X = xPosition,
                Y = yPosition
            };
            IPositionValidator positionValidator = new PositionValidator(tableLength, tableWidth);

            bool isValid = positionValidator.Validate(currentPosition);

            Assert.That(isValid);
        }

        [TestCase(5, 5)]
        [TestCase(5, 1)]
        [TestCase(1, 5)]
        [TestCase(-1, -1)]
        [TestCase(-1, 0)]
        [TestCase(0, -1)]
        public void Invalid_Positions_Return_False(int xPosition, int yPosition)
        {
            int tableLength = 5;
            int tableWidth = 5;
            Position currentPosition = new Position
            {
                Facing = Direction.NORTH,
                X = xPosition,
                Y = yPosition
            };
            IPositionValidator positionValidator = new PositionValidator(tableLength, tableWidth);

            bool isValid = positionValidator.Validate(currentPosition);

            Assert.That(!isValid);
        }

        [Test]
        public void Null_Position_Return_False()
        {
            int tableLength = 5;
            int tableWidth = 5;
            Position currentPosition = null;
            IPositionValidator positionValidator = new PositionValidator(tableLength, tableWidth);

            bool isValid = positionValidator.Validate(currentPosition);

            Assert.That(!isValid);
        }
    }
}
