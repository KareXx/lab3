using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TernavskyVadym3
{
    internal class Point
    {
        private double x;
        private double y;
        private string name;

        public Point(double x, double y, string name)
        {
            this.x = x;
            this.y = y;
            this.name = name;
        }

        public double getX() { return x; }
        public double getY() { return y; }
        public string getName() { return name; }


    }
}
