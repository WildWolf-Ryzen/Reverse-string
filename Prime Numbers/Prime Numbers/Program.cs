using System;

namespace Prime_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number to check if its prime or not.");
            int number, a=0;
            number = Convert.ToInt32(Console.ReadLine());

            for(int i = 1; i<=number; i++)
            {
                if(number % i == 0)
                {
                    a++;
                }

            }
            if(a == 2)
            {
                Console.WriteLine($"{number} is a prime number!");
            }
            else
                Console.WriteLine($"{number} is not a prime number!");


        }
    }
}
