using System;
using MarsRoverApp.Core;
using MarsRoverApp.DTO;
using MarsRoverApp.DTO.Enum;
using Xunit;

namespace MarsRoverApp.Test
{
    public class MarsRoverAppTest
    {
        [Theory]
        [InlineData("1 2 N")]
        public void TurnLeft_When_DirectionIsNorth_Then_DirectionIsWest(string definedPositions)
        {
            var positions = new PositionsDto { Positions = definedPositions };
            var positionList = new Position(positions);
            var rover = new Rover(positionList);

            rover.TurnLeft();

            Assert.Equal(Directions.W, rover.RoverPositionAndDirections.Direction);
        }
    }
}
