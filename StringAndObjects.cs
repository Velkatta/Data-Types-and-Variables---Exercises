using System;

namespace _6._Strings_and_Objects
{
    class StringAndObjects
    {
        static void Main(string[] args)
        {
            string first = "Hello";
            string second = "World";

            object third = first + " " + second;
            string fourth = (string)third;

            Console.WriteLine(fourth);
        }
    }
}