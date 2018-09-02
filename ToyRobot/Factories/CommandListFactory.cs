using System;
using System.Collections.Generic;
using ToyRobot.Commands;

namespace ToyRobot.Factories
{
    public static class CommandListFactory
    {
        public static IDictionary<string, Type> DefaultCommands
        {
            get => new Dictionary<string, Type>
            {
                { "PLACE",  typeof(PlaceCommand)  },
                { "REPORT", typeof(ReportCommand) },
                { "MOVE",   typeof(MoveCommand)   },
                { "LEFT",   typeof(LeftCommand)   },
                { "RIGHT",  typeof(RightCommand)  }
            };            
        }
    }
}
