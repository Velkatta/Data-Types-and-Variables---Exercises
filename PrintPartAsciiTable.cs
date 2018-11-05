using System;

namespace _17._Print_Part_Of_ASCII_Table
{
    class PrintPartAsciiTable
    {
        static void Main(string[] args)
        {
            int startIndex = int.Parse(Console.ReadLine()); 
            int stopIndex = int.Parse(Console.ReadLine());

            for (char i = (char)startIndex; i <= (char)stopIndex; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}