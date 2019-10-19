using System;

namespace HWSquare
{
    public class Square
    {
        private double _sideLength;

        public Square(double sideLength)
        {
            _sideLength = sideLength;
        }

        public double CalculateSquarePerimeter()
        {
            double perimeter = 4 * _sideLength;
            return perimeter;
        }

        public double CalculateSquareOfSquare()
        {
            double square = _sideLength * _sideLength;
            return square;
        }
    }

    
}
