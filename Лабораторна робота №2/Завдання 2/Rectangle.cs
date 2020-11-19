using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Завдання_2
{
    class Rectangle
    {
        public double side1 = 0.0d;
        public double side2 = 0.0d;
        public Rectangle(double s1, double s2)
        {
            this.side1 = s1;
            this.side2 = s2;
        }

        public double AreaCalculator()
        {
            double area = side1 * side2;
            return area;
        }
        public double PerimeterCalculator()
        {
            double perimetr = (side1 + side2) * 2;
            return perimetr;
        }

        public double Area
        {
            get { return AreaCalculator(); }
        }

        public double Perimeter
        {
            get { return PerimeterCalculator(); }
        }
    }
}
