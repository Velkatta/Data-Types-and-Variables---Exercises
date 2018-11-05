using System;

namespace _5._Boolean_Variable
{
    class BoolVar
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

           bool result = Convert.ToBoolean(input);
            if (result)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}