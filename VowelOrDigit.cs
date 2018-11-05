using System;

namespace _13._Vowel_or_Digit
{
    class VowelOrDigit
    {
        static void Main(string[] args)
        {
            char symbol = char.Parse(Console.ReadLine());

            if (symbol == 'a' || symbol == 'o' || symbol == 'e' || symbol == 'u' || symbol == 'i' || symbol == 'y')
            {
                Console.WriteLine("vowel");
            }
            else if (symbol >= 48 && symbol <= 57) 
            {
                Console.WriteLine("digit");
            }
            else
            {
                Console.WriteLine("other");
            }
        }
    }
}