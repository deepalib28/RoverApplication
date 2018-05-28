using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoverApplication
{
    public class Rover
    {
        public CurrentPosition ExceuteCommand(string command, CurrentPosition position)
        {
           var currentPosition = position;
           foreach(var c in command)
           {
                switch(c)
                {
                    case 'M':
                        position = currentPosition;
                        currentPosition = UpdatePosition("M", position);
                        break;
                    case 'L':
                        position = currentPosition;
                        currentPosition = IdentifyCommand('L', position);
                        break;
                    case 'R':
                        position = currentPosition;
                        currentPosition = IdentifyCommand('R', position);
                        break;
                }
           }
            return currentPosition;
        }

        private CurrentPosition IdentifyCommand(char command, CurrentPosition currentPosition)
        {
            if (command == 'L' && currentPosition.Direction.Equals(Direction.North))
                currentPosition.Direction = Direction.West;
            else if (command == 'R' && currentPosition.Direction.Equals(Direction.North))
                currentPosition.Direction = Direction.East;

            else if(command == 'L' && currentPosition.Direction.Equals(Direction.South))
                currentPosition.Direction = Direction.East;
            else if (command == 'R' && currentPosition.Direction.Equals(Direction.South))
                currentPosition.Direction = Direction.West;

            else if(command == 'L' && currentPosition.Direction.Equals(Direction.East))
                currentPosition.Direction = Direction.North;
            else if (command == 'R' && currentPosition.Direction.Equals(Direction.East))
                currentPosition.Direction = Direction.South;

            else if(command == 'L' && currentPosition.Direction.Equals(Direction.West))
                currentPosition.Direction = Direction.South;
            else if (command == 'R' && currentPosition.Direction.Equals(Direction.West))
                currentPosition.Direction = Direction.North;

            return currentPosition;
        }

        private CurrentPosition UpdatePosition(string command, CurrentPosition position)
        {
            var currPosition = position;
            if(position.Direction.Equals(Direction.North))
            {
                currPosition = new CurrentPosition(new Points(position.Points.X, position.Points.Y + 1), Direction.North);
            }
            if (position.Direction.Equals(Direction.South))
            {
                currPosition = new CurrentPosition(new Points(position.Points.X, position.Points.Y - 1), Direction.South);
            }
            if (position.Direction.Equals(Direction.East))
            {
                currPosition = new CurrentPosition(new Points(position.Points.X+1, position.Points.Y), Direction.East);
            }
            if (position.Direction.Equals(Direction.West))
            {
                currPosition = new CurrentPosition(new Points(position.Points.X-1, position.Points.Y), Direction.West);
            }
            return currPosition;
        }
    }
}
