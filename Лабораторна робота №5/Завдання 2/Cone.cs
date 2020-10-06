using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Завдання_2
{
    class Cone
    {
        public double height;
        public double radius;
        public double volume;
        public double area;
        public Cone(double h, double r)
        {
            this.height = h;
            this.radius = r;
        }
        public virtual void Volume()
        {
            volume = (Math.PI * Math.Pow(radius, 2) * height) / 3;
            Console.WriteLine($"Объем конуса = {volume}");
        }
        public virtual void Area()
        {
            area = Math.PI * Math.Pow(radius, 2);
            Console.WriteLine($"Площадь основания конуса = {area}");
        }
    }
}
