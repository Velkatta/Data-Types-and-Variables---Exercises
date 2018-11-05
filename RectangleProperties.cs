using System;

namespace _12._Rectangle_Properties
{
    class RectangleProperties
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double heigth = double.Parse(Console.ReadLine());

            double perimeter = (2 * width) + (2 * heigth);
            double area = width * heigth;
            double diagonal = Math.Sqrt((width * width) + (heigth * heigth));
                 
            Console.WriteLine(perimeter);
            Console.WriteLine(area);
            Console.WriteLine(diagonal);
        }
    }
}