using System;

namespace OperatorExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // var a = 17;
            // var b = 4;

            // var add = a + b;
            // var sub = a - b;
            // var mult = a * b; 
            // var div = a / b;
            // var mod = a % b;

            // Console.WriteLine($"The sum is {add}, the difference is {sub}, and the product is {mult}.");
            // Console.WriteLine();
            // Console.WriteLine($"{a} / {b} is {div} remainder {mod}");
            // Console.WriteLine();
            Console.WriteLine("What is the area of the circle:");
            var radius = double.Parse(Console.ReadLine());
            var areaOfCircle = CalculateArea(radius);

            Console.WriteLine($"The area of a circle with radius of {radius} is {areaOfCircle}");
        }

        public static double CalculateArea(double radius)
        {
            return Math.PI * (radius * radius);
        }
    }
}
