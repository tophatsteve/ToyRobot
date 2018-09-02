using System;
using ToyRobot.Constants;
using ToyRobot.Logic;
using ToyRobot.Models;

namespace ToyRobot.Commands
{
    public class ReportCommand : AbstractCommand, ICommand
    {
        public ReportCommand(string[] parameters) : base(parameters)
        {
        }

        public Position Execute(Position currentPosition, IPositionValidator positionValidator)
        {
            if (currentPosition == null)
            {
                Console.Out.WriteLine($"Output: {ErrorMessages.NotPlaced}");
            }
            else
            {
                Console.Out.WriteLine($"Output: {currentPosition.ToString()}");
            }

            return currentPosition;
        }
    }
}
