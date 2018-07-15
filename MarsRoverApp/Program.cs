using System;
using MarsRoverApp.Core;
using MarsRoverApp.DTO;

namespace MarsRoverApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("1th Rover Position and Direction : ");
            var firstRoverPosition = Console.ReadLine();

            Console.Write("1th Rover Directives : ");
            var firstRoverDirectives = Console.ReadLine();

            var positions = new PositionsDto {Positions = firstRoverPosition};
            var position = new Position(positions);
            Rover firstRover = new Rover(position);
            firstRover.Process(firstRoverDirectives);

            Console.Write("2nd Rover Position and Direction : ");
            var secondRoverPosition = Console.ReadLine();
            Console.Write("2nd Rover Directives : ");
            var secondRoverDirectives = Console.ReadLine();


            var positionsSecond = new PositionsDto { Positions = secondRoverPosition };
            var positionSecond = new Position(positionsSecond);
            Rover secondRover = new Rover(positionSecond);
            secondRover.Process(secondRoverDirectives);

            Console.WriteLine("Result");
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine(firstRover.ToString());
            Console.WriteLine(secondRover.ToString());
            Console.WriteLine(Environment.NewLine);

            Console.ReadLine();
        }
    }
}
