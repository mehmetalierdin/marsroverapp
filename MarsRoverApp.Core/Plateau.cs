using System;
using System.Collections.Generic;
using System.Text;
using MarsRoverApp.DTO;

namespace MarsRoverApp.Core
{
    public class Plateau : IPlateau
    {
        public DimensionsDto PlateauDimentions { get; private set; }

        public Plateau(DimensionsDto dimentions)
        {
            PlateauDimentions = dimentions;
        }
    }
}
