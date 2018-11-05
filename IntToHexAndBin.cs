using System;

namespace _14._Integer_to_Hex_and_Binary
{
    class IntToHexAndBin
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            string resultHex = Convert.ToString(input, 16);
            string resultBin = Convert.ToString(input, 2);

            string upper = resultHex.ToUpper();

            Console.WriteLine(upper);
            Console.WriteLine(resultBin);
        }
    }
}