using System;
using System.Collections.Generic;
using System.Reflection;
using ToyRobot.Commands;
using ToyRobot.Factories;

namespace ToyRobot.Logic
{
    public class CommandParser : ICommandParser
    {
        // public property to all changing of the command set at runtime
        public IDictionary<string, Type> CommandTypes {get; set;}

        public CommandParser()
        {
            CommandTypes = CommandListFactory.DefaultCommands;
        }

        public ICommand Parse(string command)
        {
            string commandName = GetCommandName(command);

            if (CommandTypes.ContainsKey(commandName))
            {
                string[] commandParameters = GetCommandParameters(command);
                return CreateCommand(commandName, commandParameters);
            }

            return new UnknownCommand(NoParameters());
        }

        private ICommand CreateCommand(string commandName, string[] commandParameters)
        {
            ConstructorInfo ctor = CommandTypes[commandName].GetConstructor(new Type[] { commandParameters.GetType() });
            object[] parameterValues = new object[] { commandParameters };
            return (ICommand)ctor.Invoke(parameterValues);
        }

        private string GetCommandName(string command)
        {
            string[] commandComponents = GetCommandComponents(command);

            if (commandComponents.Length == 0)
            {
                return string.Empty;
            }

            return commandComponents[0].ToUpper();
        }

        private string[] GetCommandParameters(string command)
        {
            string[] commandComponents = GetCommandComponents(command);

            if (commandComponents.Length < 2)
            {
                return new string[] { };
            }

            return commandComponents[1].ToUpper().Split(',');
        }

        private string[] GetCommandComponents(string command)
        {
            if (string.IsNullOrWhiteSpace(command))
            {
                return new string[] { };
            }

            return command.Split(' ');
        }

        private string[] NoParameters() => new string[] { };
    }
}
