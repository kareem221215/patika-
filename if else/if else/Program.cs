using System;

namespace if_else
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("pick a number");
            long num = Convert.ToInt64(Console.ReadLine());
            if (num > 10)
            {
                Console.WriteLine("number is greater than 10");
            }
            else if (num == 10)
            {
                Console.WriteLine("number is equal to 10");
            }
            else
            {
                Console.WriteLine("number is greater than 10");
            }

            if(num % 2 == 0)
            {
                Console.WriteLine("numebr is even");
            }

            else
            {
                Console.WriteLine("number is odd");
            }
            Console.ReadLine();
        }
    }
}
