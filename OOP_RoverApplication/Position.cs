using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_RoverApplication
{
    public class Position
    {
        public Position(Points coordinates, Direction direction)
        {
            Points = coordinates;
            Direction = direction;
        }
        public Points Points { get; set; }

        public Enum Direction { get; set; }
    }
    public class Points
    {
        public Points(int x, int y)
        {
            X = x;
            Y = y;
        }
        public int X { get; set; }
        public int Y { get; set; }
    }
    public enum Direction
    {
        North,
        South,
        East,
        West
    }
}
