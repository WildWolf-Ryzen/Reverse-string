using System;

namespace Reverse_string
{
    class Program
    {
        static void Main(string[] args)
        {
            string reverseString = "Jovanov";
            var charArray = reverseString.ToCharArray();

            Console.WriteLine("Reversed:");

            for (int i = 0; i < charArray.Length; i++)
            {
                Array.Reverse(charArray);
                Console.WriteLine(charArray[i]);
            }
        }
    }
}