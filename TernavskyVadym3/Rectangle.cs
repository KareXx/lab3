using System;



namespace TernavskyVadym3
{
    public class Rectangle
    {
        private double side1;
        private double side2;

        public Rectangle(double side1, double side2)
        {

            if (side1 <= 0 || side2 <= 0)
            {
                throw new ArgumentException("Довжина сторін не може бути менше або рівною 0.");
            }


            this.side1 = side1;
            this.side2 = side2;

          
        }

        public double CalculateArea()
        {
            return side1 * side2;
        }

        public double CalculatePerimeter()
        { 
            return 2 * (side1 + side2);
        }

        public double Area
        {
            get { return CalculateArea(); }
        }

        public double Perimeter 
        {
            get { return CalculatePerimeter(); }
        }
    }
}

