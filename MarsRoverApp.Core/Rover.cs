using System;
using System.Collections.Generic;
using System.Text;
using MarsRoverApp.DTO;
using MarsRoverApp.DTO.Enum;

namespace MarsRoverApp.Core
{
    public class Rover : IRover
    {
        public Position RoverPositionAndDirections { get; set; }
        public Rover(Position roverPositionAndDirections)
        {
            RoverPositionAndDirections = roverPositionAndDirections;
        }
        public void Process(string commands)
        {
            foreach (var command in commands)
            {
                switch (command)
                {
                    case ('L'):
                        TurnLeft();
                        break;
                    case ('R'):
                        TurnRight();
                        break;
                    case ('M'):
                        Move();
                        break;
                    default:
                        throw new ArgumentException(string.Format("Invalid value: {0}", command));
                }
            }
        }
        public void TurnLeft()
        {
           RoverPositionAndDirections.Direction  = (RoverPositionAndDirections.Direction - 1) < Directions.N ? Directions.W : RoverPositionAndDirections.Direction - 1;
        }
        public void TurnRight()
        {
            RoverPositionAndDirections.Direction = (RoverPositionAndDirections.Direction + 1) > Directions.W ? Directions.N : RoverPositionAndDirections.Direction + 1;
        }
        public void Move()
        {
            if (RoverPositionAndDirections.Direction == Directions.N)
            {
                RoverPositionAndDirections.YCoordinate++;
            }
            else if (RoverPositionAndDirections.Direction == Directions.E)
            {
                RoverPositionAndDirections.XCoordinate++;
            }
            else if (RoverPositionAndDirections.Direction == Directions.S)
            {
                RoverPositionAndDirections.YCoordinate--;
            }
            else if (RoverPositionAndDirections.Direction == Directions.W)
            {
                RoverPositionAndDirections.XCoordinate--;
            }
        }
        public override string ToString()
        {
            return string.Format("{0} {1} {2}", RoverPositionAndDirections.XCoordinate, RoverPositionAndDirections.YCoordinate, RoverPositionAndDirections.Direction);
        }
    }
}
