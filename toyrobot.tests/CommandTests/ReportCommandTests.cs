using NUnit.Framework;
using System;
using System.IO;
using ToyRobot.Commands;
using ToyRobot.Constants;
using ToyRobot.Enums;
using ToyRobot.Logic;
using ToyRobot.Models;

namespace ToyRobot.Tests.CommandTests
{
    [TestFixture]
    public class ReportCommandTests
    {
        [Test]
        public void ReportCommand_WithoutSetCurrentPosition_Reports_NotPlacedMessage()
        {
            Position currentPosition = null;
            IPositionValidator positionValidator = new PositionValidator(5, 5);
            ICommand reportCommand = new ReportCommand(new string[] { });
            StringWriter reportOutput = new StringWriter();
            Console.SetOut(reportOutput);

            Position newPosition = reportCommand.Execute(currentPosition, positionValidator);

            Assert.That(reportOutput.ToString() == $"Output: {ErrorMessages.NotPlaced}\r\n");
        }

        [Test]
        public void ReportCommand_SetCurrentPosition_Reports_CorrectPosition()
        {
            Position currentPosition = new Position
            {
                Facing = Direction.NORTH,
                X = 1,
                Y = 1
            };
            IPositionValidator positionValidator = new PositionValidator(5, 5);
            ICommand reportCommand = new ReportCommand(new string[] { });
            StringWriter reportOutput = new StringWriter();
            Console.SetOut(reportOutput);

            Position newPosition = reportCommand.Execute(currentPosition, positionValidator);

            Assert.That(reportOutput.ToString() == $"Output: 1,1,NORTH\r\n");
        }

        [Test]
        public void ReportCommand_Returns_UnchangedPosition()
        {
            Position currentPosition = new Position
            {
                Facing = Direction.NORTH,
                X = 0,
                Y = 0
            };
            IPositionValidator positionValidator = new PositionValidator(5, 5);
            ICommand reportCommand = new ReportCommand(new string[] { });

            Position newPosition = reportCommand.Execute(currentPosition, positionValidator);

            Assert.That(newPosition.X == currentPosition.X);
            Assert.That(newPosition.Y == currentPosition.Y);
            Assert.That(newPosition.Facing == currentPosition.Facing);
        }
    }
}
