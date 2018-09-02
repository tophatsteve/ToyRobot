using ToyRobot.Logic;
using ToyRobot.Models;

namespace ToyRobot.Factories
{
    public static class RobotFactory
    {
        public static IRobot Create(int tableLength, int tableWidth)
        {
            return new Robot(
                new CommandParser(), 
                new PositionValidator(tableLength, tableWidth)
            );
        }
    }
}
