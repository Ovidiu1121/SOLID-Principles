using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema82_SOLID_Principles.Open_Closed_Principle
{
    //public class AreaCalculator
    //{
    //    public double TotalArea(object[] arrObjects)
    //    {
    //        double area = 0;
    //        Rectangle objRectangle;
    //        Circle objCircle;
    //        foreach (var obj in arrObjects)
    //        {
    //            if (obj is Rectangle)
    //            {
    //                objRectangle=(Rectangle)obj;
    //                area += objRectangle.Height * objRectangle.Width;
    //            }
    //            else
    //            {
    //                objCircle = (Circle)obj;
    //                area += objCircle.Radius * objCircle.Radius * Math.PI;
    //            }
    //        }
    //        return area;
    //    }
    //}

  //pentru clasa de sus cand cream o noua forma trebuia sa modificam functia mereu-->> ne folosim de clasele abstracte

    public class AreaCalculator
    {
        public double TotalArea(Shape[] arrShapes)
        {
            double area = 0;
            foreach (var objShape in arrShapes)
            {
                area += objShape.Area();
            }
            return area;
        }
    }

}
