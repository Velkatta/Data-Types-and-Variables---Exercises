using System;

namespace _11._Convert_Speed_Units
{
    class ConvertsSpeedUnits
    {
        static void Main(string[] args)
        {
            double distanceMeters = double.Parse(Console.ReadLine());
            double hours = double.Parse(Console.ReadLine());
            double minutes = double.Parse(Console.ReadLine());
            double seconds = double.Parse(Console.ReadLine());
            double time = seconds + minutes * 60 + hours * 3600;

            double metersPerSec = distanceMeters / time;
            double kmPerHour = (distanceMeters / 1000) / (time / 3600);
            double milesPerHour = (distanceMeters / 1609) / (time / 3600);

            Console.WriteLine($"{metersPerSec:0.######}");
            Console.WriteLine($"{kmPerHour:0.######}");
            Console.WriteLine($"{milesPerHour:0.######}");         
        }
    }
}