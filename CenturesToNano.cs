using System;
using System.Numerics;

namespace _10._Centuries_to_Nanoseconds
{
    class CenturesToNano
    {
        static void Main(string[] args)
        {
            int centures = int.Parse(Console.ReadLine());

            int years = centures * 100;
            int days = (int)(years * 365.2422);
            int hours = days * 24;
            ulong minutes = (ulong)(hours * 60);
            BigInteger seconds = (minutes * 60);
            BigInteger miliseconds = (BigInteger)(seconds * 1000);
            BigInteger microseconds = (BigInteger)(miliseconds * 1000);
            BigInteger nanoseconds = (BigInteger)(microseconds * 1000);

            Console.WriteLine($"{centures} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = {seconds} seconds = {miliseconds} milliseconds = {microseconds} microseconds = {nanoseconds} nanoseconds");

        }
    }
}
