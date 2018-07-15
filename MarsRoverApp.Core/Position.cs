using System;
using System.Collections.Generic;
using System.Text;
using MarsRoverApp.DTO;
using MarsRoverApp.DTO.Enum;

namespace MarsRoverApp.Core
{

    public class Position : IPosition
    {
        public int XCoordinate { get; set; }
        public int YCoordinate { get; set; }
        public Directions Direction { get; set; }

        public Position(PositionsDto position)
        {
            try
            {
                var coordinates = position.Positions.Split(' ');
                if (coordinates.Length > 1)
                {
                    int.TryParse(coordinates[0], out int x);
                    int.TryParse(coordinates[1], out int y);
                    XCoordinate = x;
                    YCoordinate = y;
                    Direction = Enum.Parse<Directions>(coordinates[2]);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }
    }
}
