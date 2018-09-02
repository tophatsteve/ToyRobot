using System;
using ToyRobot.Enums;

namespace ToyRobot.Models
{
    public class Position
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Direction Facing { get; set; }

        public Position()
        {
        }

        public Position(Position other)
        {
            Facing = other.Facing;
            X = other.X;
            Y = other.Y;
        }

        public override string ToString()
        {
            return $"{X},{Y},{Facing.ToString()}";
        }
    }
}
