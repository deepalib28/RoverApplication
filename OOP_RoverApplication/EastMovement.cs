using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_RoverApplication
{
    class EastMovement : IMovement
    {
        public Position Move(Position position)
        {
           return new Position(new Points(position.Points.X + 1, position.Points.Y), Direction.East);
        }

        public Position TurnLeft(Position position)
        {
            position.Direction = Direction.North;
            return position;
        }

        public Position TurnRight(Position position)
        {
            position.Direction = Direction.South;
            return position;
        }
    }
}
