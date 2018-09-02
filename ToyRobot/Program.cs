using System;
using ToyRobot.Factories;
using ToyRobot.Models;

namespace ToyRobot
{
    class Program
    {
        private const int TABLE_LENGTH = 5;
        private const int TABLE_WIDTH = 5;

        static void Main(string[] args)
        {
            DisplayIntroductoryText();

            IRobot robot = RobotFactory.Create(TABLE_LENGTH, TABLE_WIDTH);

            while(true)
            {
                string command = Console.ReadLine();
                robot.ExecuteCommand(command);
            }
        }

        static void DisplayIntroductoryText()
        {
            Console.Out.WriteLine("Toy Robot Simulator");
            Console.Out.WriteLine("===================");
            Console.Out.WriteLine("Please enter a command");
        }
    }
}
