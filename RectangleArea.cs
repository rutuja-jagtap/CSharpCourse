using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasics
{
    class RectangleArea
    {
        static double CalculateArea(double len,double wid)
        {
            return len * wid;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter length and bradth to calcute area of rectangle\n");
            double len=Convert.ToDouble(Console.ReadLine());
            double wid= Convert.ToDouble(Console.ReadLine());
            double res = RectangleArea.CalculateArea(len, wid);
            Console.WriteLine("Length="+len+ "\n" + "Width="+wid+"\n"+"Area of rectangle ="+res);
        }
    }
}
