using System;

namespace _7._Exchange_Variable_Values
{
    class ExchangeVar
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;

            Console.WriteLine("Before:");
            Console.WriteLine($"a = {a}");
            Console.WriteLine($"b = {b}");

            int temp = a; // temp = 5
            a = b;        //a = 10;
            b = temp;     //b = 5   
            Console.WriteLine("After:");
            Console.WriteLine($"a = {a}");
            Console.WriteLine($"b = {b}");
        }
    }
}
