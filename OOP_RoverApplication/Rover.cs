using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_RoverApplication
{
    public class Rover
    {
        //Singleton pattern
        private static Rover _rover=null;
        private static object _classLock = typeof(Rover);
        private Rover()
        {

        }
        public static Rover getInstance()
        {
            lock(_classLock)//for multithreading //thred safe
            {
                if (_rover == null)
                {
                    _rover = new Rover();
                }
            }
            return _rover;
        }
         //////Singleton pattern ends///////  
        

        public Position ExceuteCommand(string command, Position position)
        {
            var currentPosition = position;

            IMovement directionStrategy = null;
            directionStrategy = GetDirectionStrategy(position.Direction);

            foreach (var c in command)
            {
                
                switch (c)
                {
                    case 'L':
                        currentPosition = directionStrategy.TurnLeft(position);
                        break;
                    case 'R':
                        currentPosition = directionStrategy.TurnRight(position);
                        break;
                    case 'M':
                        currentPosition = directionStrategy.Move(position);
                        break;
                }
                position = currentPosition;
                directionStrategy = GetDirectionStrategy(position.Direction);
            }

            return position;
        }


       //strategy pattern
        private IMovement GetDirectionStrategy(Enum direction)
        {
            IMovement directionStrategy = null;
            switch (direction)
            {
                case Direction.North:
                    directionStrategy = new NorthMovement();
                    break;

                case Direction.South:
                    directionStrategy = new SouthMovement();
                    break;

                case Direction.East:
                    directionStrategy = new EastMovement();
                    break;

                case Direction.West:
                    directionStrategy = new WestMovement();
                    break;
            }
            return directionStrategy;
        }


       
    }
}
