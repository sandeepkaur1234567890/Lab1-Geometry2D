using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
    namespace Geometry2D
    {
        public class Point
        {
            public double X { get; set; }
            public double Y { get; set; }

            public Point(double x = 0, double y = 0)
            {
                X = x;
                Y = y;
            }

            public void GetCoords(out double x, out double y)
            {
                x = X;
                y = Y;
            }

            public void SetCoords(double? x, double? y)
            {
                X = x ?? X;
                Y = y ?? Y;
            }

            public override string ToString() => $"({X}, {Y})";
        }

        public class Vector
        {
            public double DX { get; private set; }
            public double DY { get; private set; }

            public Vector(double dx = 0, double dy = 0)
            {
                Set(dx, dy);
            }

            public void Set(double dx, double dy)
            {

                if (dx <= -1 && dy >= 1 || dx >= 1 && dy <= -1)
                {
                    dx = DX;
                    dy = DY;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Invalid argument");
                }
            }

            public override string ToString() => $"({DX}, {DY})";
        }

        public class Rectangle
        {
            public double Length { get; }
            public double Width { get; }
            public double Area { get; }


            public Rectangle(double Length, double Width)
            {
                Rectangle_Area(Length, Width);
            }

            public void Rectangle_Area(double Length, double Width)
            {
                double Area = (Length * Width);
                Console.WriteLine(Area);
            }
        }
    }
}
