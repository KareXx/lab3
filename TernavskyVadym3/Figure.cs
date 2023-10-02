using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TernavskyVadym3
{
    internal class Figure
    {
        private Point[] points;

        public Figure(Point point1, Point point2, Point point3)
        {
            points = new Point[] { point1, point2, point3 };
        }

        public Figure(Point point1, Point point2, Point point3, Point point4)
        {
            points = new Point[] { point1, point2, point3, point4 };
        }

        public Figure(Point point1, Point point2, Point point3, Point point4, Point point5)
        {
            points = new Point[] { point1, point2, point3, point4, point5 };
        }

        public double GetSideLength(Point A, Point B)
        {
            return Math.Sqrt(Math.Pow(B.getX() - A.getX(), 2) + Math.Pow(B.getY() - A.getY(), 2));
        }

        public void CalculatePerimeter()
        {
            double perimeter = 0;
            int pointCount = points.Length;

            if (pointCount < 2)
            {
                Console.WriteLine("Неможливо обчислити периметр з менше, ніж 2 точок.");
                return;
            }

            for (int i = 0; i < pointCount; i++)
            {
                int nextIndex;

                if (i == pointCount - 1)
                {
                    nextIndex = 0; 
                }
                else
                {
                    nextIndex = i + 1;
                }

                double sideLength = GetSideLength(points[i], points[nextIndex]);
                perimeter += sideLength;
            }


            string polygonType = "невідомий багатокутник";

            if (pointCount == 3)
            {
                polygonType = "трикутник";
            }
            else if (pointCount == 4)
            {
                polygonType = "чотирикутник";
            }
            else if (pointCount == 5)
            {
                polygonType = "п'ятикутник";
            }

            Console.WriteLine($"Це {polygonType}. Периметр: {perimeter}");

        }
    }
}
