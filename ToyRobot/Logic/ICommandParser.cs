using ToyRobot.Commands;

namespace ToyRobot.Logic
{
    public interface ICommandParser
    {
        ICommand Parse(string command);
    }
}
