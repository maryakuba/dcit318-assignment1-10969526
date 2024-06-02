using System;

namespace TriangleTypeIdentifier
{
    class Triangle
    {
        private double side1, side2, side3;

        public Triangle(double s1, double s2, double s3)
        {
            side1 = s1;
            side2 = s2;
            side3 = s3;
        }

        public string IdentifyTriangleType()
        {
            if (side1 == side2 && side2 == side3)
                return "Equilateral";
            else if (side1 == side2 || side1 == side3 || side2 == side3)
                return "Isosceles";
            else
                return "Scalene";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the lengths of the three sides of the triangle:");
            double side1 = Convert.ToDouble(Console.ReadLine());
            double side2 = Convert.ToDouble(Console.ReadLine());
            double side3 = Convert.ToDouble(Console.ReadLine());

            Triangle triangle = new Triangle(side1, side2, side3);
            string triangleType = triangle.IdentifyTriangleType();

            Console.WriteLine($"The triangle is: {triangleType}");
        }
    }
}