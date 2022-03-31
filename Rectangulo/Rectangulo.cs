using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoRectangulo
{
    public class Rectangulo
    {
        public double x1 { get; set; }
        public double y1 { get; set; }

        public double x2 { get; set; }
        public double y2 { get; set; }

        public double x3 { get; set; }
        public double y3 { get; set; }

        public double x4 { get; set; }
        public double y4 { get; set; }


        public double Area(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
        {
            double u = Math.Abs(x2 - x1);
            double v = Math.Abs(y3 - y1);
            double area = u * v;
            return area;
        }
        public double Perimetro(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
        {
            double perimetro = (2 * (x2 - x1) + 2 * (y3 - y1));
            return perimetro;
        }


    }
}
