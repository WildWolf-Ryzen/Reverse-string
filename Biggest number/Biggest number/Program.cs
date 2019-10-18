using System;

namespace Biggest_number
{
    class Program
    {
        static int printMaxNum(int num)
        {
            int[] count = new int[10];

            String str = num.ToString();

            for (int i = 0; i < str.Length; i++)
                count[str[i] - '0']++;

            int result = 0, multiplier = 1;
            for (int i = 0; i <= 9; i++)
            {
                while (count[i] > 0)
                {
                    result = result + (i * multiplier);
                    count[i]--;
                    multiplier = multiplier * 10;
                }
            }
            return result;
        }

        public static void Main()
        {
            int num;
            Console.WriteLine("Enter a number!");
            num = Convert.ToInt32(Console.ReadLine());

            Console.Write(printMaxNum(num));
        }
    }
}
