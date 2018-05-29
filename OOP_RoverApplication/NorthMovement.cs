using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_RoverApplication
{
    public class NorthMovement : IMovement
    {
        public Position TurnLeft(Position position)
        {
            position.Direction = Direction.West;
            return position;
        }

        public Position TurnRight(Position position)
        {
            position.Direction = Direction.East;
            return position;
        }

        public  Position Move(Position position)
        {
            return new Position(new Points(position.Points.X, position.Points.Y + 1), Direction.North);
        }

    }
}
