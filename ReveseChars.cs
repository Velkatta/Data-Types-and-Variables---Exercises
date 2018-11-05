using System;

namespace _09._Reversed_chars
{
    class ReveseChars
    {
        static void Main(string[] args)
        {
            char[] array = new char[3];

            for (int i = array.Length - 1; i >= 0; i--)
            {
                array[i] = char.Parse(Console.ReadLine());
            }
            string str = new string(array);
            Console.WriteLine(str);
        }
    }
}