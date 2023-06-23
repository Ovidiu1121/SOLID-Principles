using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema82_SOLID_Principles.Open_Closed_Principle
{
    //public class Rectangle
    //{
    //    public double Height { get; set; }
    //    public double Width { get; set; }
    //}

    public class Rectangle : Shape
    {
        public double Height { get; set; }
        public double Width { get; set; }
        public override double Area()
        {
            return Height * Width;
        }
    }

}
