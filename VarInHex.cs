using System;

namespace _4._Variable_in_Hexadecimal_Format
{
    class VarInHex
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Console.WriteLine(Convert.ToInt32(input, 16));
            //int result = Convert.ToInt32(input, 16);
            //Console.WriteLine(result);
        }
    }
}