using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace завдання_4
{
    class Point
    {
        public string name;
        public int number;
        public int pointA;
        public int pointB;
        public int PointA
        {
            get
            {
                return pointA;
            }
        }

        public int PointB
        {
            get
            {
                return pointB;
            }
        }
        public int Number
        {
            get
            {
                return number;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
        }
        public Point()
            : this("", 0, 0) { }
        public Point(string name, int pointA, int number)
        {
            this.name = name;
            this.pointA = pointA;
            this.number = number;
        }
    }
}
