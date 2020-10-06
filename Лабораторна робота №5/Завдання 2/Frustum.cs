using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Завдання_2
{
    class Frustum : Cone
    {
        public double rSM;
        public Frustum(double h, double r, double rSmall)
        : base(h,r)
        {
            this.rSM = rSmall;
        }
        public override void Volume()
        {
            volume = (Math.PI * height * (Math.Pow(radius, 2) + radius * rSM + Math.Pow(rSM, 2))) / 3;
            Console.WriteLine($"Объем усеченного конуса = {volume}");
        }
        public override void Area()
        {
            area = Math.PI * Math.Pow(radius, 2);
            Console.WriteLine($"Площадь основания усеченного конуса = {area}");
        }
    }
}
