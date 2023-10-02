using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace TernavskyVadym3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // testing the first task
            try
            {
                Console.Write("Введіть довжину першої сторони прямокутника: ");
                double side1 = double.Parse(Console.ReadLine());

                Console.Write("Введіть довжину другої сторони прямокутника: ");
                double side2 = double.Parse(Console.ReadLine());

                Rectangle rectangle = new Rectangle(side1, side2);

                Console.WriteLine($"Площа прямокутника: {rectangle.Area}");
                Console.WriteLine($"Периметр прямокутника: {rectangle.Perimeter}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Помилка: {ex.Message}");
            }

            // testing the second task
            Point point1 = new Point(1, 1, "A");
            Point point2 = new Point(8, 0, "B");
            Point point3 = new Point(5, 3, "C");
            Point point4 = new Point(2, 9, "D");

            Figure figure = new Figure(point1, point2, point3, point4);
            figure.CalculatePerimeter();


            Console.ReadLine();

        }
    }
}
