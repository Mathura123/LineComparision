using System;
using System.Collections.Generic;
using System.Text;

namespace LineComparision
{
    public class Lines
    {
        public double x1;
        public double x2;
        public double y1;
        public double y2;
        public double length;
        public Lines(double x1, double x2, double y1, double y2)
        {
            this.x1 = x1;
            this.x2 = x2;
            this.y1 = y1;
            this.y2 = y2;
            this.length = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
        }
    }
}
