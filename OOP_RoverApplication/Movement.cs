using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_RoverApplication
{
    interface IMovement
    {
        Position Move(Position position);

        Position TurnLeft(Position position);

        Position TurnRight(Position position);

    }
}
