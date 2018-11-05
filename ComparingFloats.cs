using System;

namespace _16._Comparing_floats
{
    class ComparingFloats
    {
        static void Main(string[] args)
        {
            double NumA = double.Parse(Console.ReadLine());
            double NumB = double.Parse(Console.ReadLine());

            double eps = 0.000001;

            double diff = Math.Max(NumA, NumB) - Math.Min(NumA, NumB);

            if (diff > eps)
            {
                Console.WriteLine("False");
            }
            else
            {
                Console.WriteLine("True");
            }
        }
    }
}