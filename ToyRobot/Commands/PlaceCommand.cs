using System;
using ToyRobot.Enums;
using ToyRobot.Exceptions;
using ToyRobot.Logic;
using ToyRobot.Models;

namespace ToyRobot.Commands
{
    public class PlaceCommand : AbstractCommand, ICommand
    {
        private string[] _parameters;

        public PlaceCommand(string[] parameters) : base(parameters)
        {
            _parameters = parameters;
        }

        public Position Execute(Position currentPosition, IPositionValidator positionValidator)
        {
            try
            {
                Position newPosition = new Position
                {
                    Facing = GetDirectionParameter(),
                    X = GetXParameter(),
                    Y = GetYParameter()
                };

                if (!positionValidator.Validate(newPosition))
                {
                    return currentPosition;
                }
                return newPosition;                
            }
            catch
            {
                return currentPosition;
            }
        }

        private int GetXParameter()
        {
            if (_parameters.Length > 0)
            {
                int xPosition = -1;
                if(int.TryParse(_parameters[0], out xPosition))
                {
                    return xPosition;
                }
            }

            throw new InvalidYPositionException();
        }

        private int GetYParameter()
        {
            if (_parameters.Length > 1)
            {
                int yPosition = -1;
                if (int.TryParse(_parameters[1], out yPosition))
                {
                    return yPosition;
                }
            }

            throw new InvalidYPositionException();
        }

        private Direction GetDirectionParameter()
        {
            if (_parameters.Length > 2)
            {
                return (Direction)Enum.Parse(typeof(Direction), _parameters[2]);
            }

            throw new InvalidDirectionException();
        }
    }
}
