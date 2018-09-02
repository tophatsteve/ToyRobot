using NUnit.Framework;
using ToyRobot.Commands;
using ToyRobot.Logic;

namespace ToyRobot.Tests.LogicTests
{
    [TestFixture]
    public class CommandParserTests
    {
        [Test]
        public void BlankCommandString_Returns_UnknownCommand()
        {
            ICommandParser parser = new CommandParser();

            ICommand command = parser.Parse("");

            Assert.That(command.GetType() == typeof(UnknownCommand));
        }

        [Test]
        public void IllegalCommandString_Returns_UnknownCommand()
        {
            ICommandParser parser = new CommandParser();

            ICommand command = parser.Parse("ILLEGAL");

            Assert.That(command.GetType() == typeof(UnknownCommand));
        }

        [Test]
        public void PlaceCommandString_Returns_PlaceCommand()
        {
            ICommandParser parser = new CommandParser();

            ICommand command = parser.Parse("PLACE 0,0,NORTH");

            Assert.That(command.GetType() == typeof(PlaceCommand));
        }

        [Test]
        public void MoveCommandString_Returns_MoveCommand()
        {
            ICommandParser parser = new CommandParser();

            ICommand command = parser.Parse("MOVE");

            Assert.That(command.GetType() == typeof(MoveCommand));
        }

        [Test]
        public void LeftCommandString_Returns_LeftCommand()
        {
            ICommandParser parser = new CommandParser();

            ICommand command = parser.Parse("LEFT");

            Assert.That(command.GetType() == typeof(LeftCommand));
        }

        [Test]
        public void RightCommandString_Returns_RightCommand()
        {
            ICommandParser parser = new CommandParser();

            ICommand command = parser.Parse("RIGHT");

            Assert.That(command.GetType() == typeof(RightCommand));
        }

        [Test]
        public void ReportCommandString_Returns_ReportCommand()
        {
            ICommandParser parser = new CommandParser();

            ICommand command = parser.Parse("REPORT");

            Assert.That(command.GetType() == typeof(ReportCommand));
        }
    }
}
