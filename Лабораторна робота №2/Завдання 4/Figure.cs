using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace завдання_4
{
    class Figure : Point
    {
        public Figure(Point pointA, Point pointB, Point number, Point name)
        {
            this.pointA = base.pointA;
            this.pointB = base.pointB;
            this.number = base.number;
            this.name = base.name;
        }

        public Figure(int pointA, int pointB, int number, string name)
        {
            this.pointA = pointA;
            this.pointB = pointB;
            this.number = number;
            this.name = name;
        }

        public int LengthSide(int A, int B)
        {
            if (B - A > 0)
                return B - A;
            else if (A - B == 0)
                return A;
            else
                return A - B;
        }
        public void PerimeterCalculator()
        {
            int perimeter = LengthSide(pointA, pointB) * number;
            Console.WriteLine($"Периметр фигуры {name} = {perimeter}");
        }
    }
}
