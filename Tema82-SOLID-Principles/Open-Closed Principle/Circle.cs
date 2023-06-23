using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema82_SOLID_Principles.Open_Closed_Principle
{
    //public class Circle
    //{
    //    public double Radius { get; set; }
    //}

    public class Circle : Shape
    {
        public double Radius { get; set; }
        public override double Area()
        {
            return Radius * Radius * Math.PI;
        }
    }

}
