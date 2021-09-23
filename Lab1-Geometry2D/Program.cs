using System;

namespace Lab1.Geometry2D
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p = new Point();

            p.SetCoords(2, 2);
            p.SetCoords(null, 2);

            Vector v1 = new Vector();
            v1.Set(-1, 1);

            Rectangle r1 = new Rectangle(2, 3);
            r1.Rectangle_Area(2, 3);
        }
    }
}
