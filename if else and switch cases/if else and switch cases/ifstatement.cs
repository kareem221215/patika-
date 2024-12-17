using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_else_and_switch_cases
{
    internal class ifstatement
    {
        static void Main(string[] args)
        {
            Console.WriteLine("dream gorcery shop!! ");
            int length = 25;
            Console.WriteLine($"{new string('=', length)} WELCOME {new string('=', length)}");
            Console.WriteLine("apple = 6 TL");
            Console.WriteLine("banana = 8 TL");
            Console.WriteLine("orange = 3 TL");
            Console.WriteLine("strawberry = 2 TL");
            Console.WriteLine("other fruits = 5 TL");
            Console.WriteLine("please choose your desired fruit (apple/banana/orange/strawberry/other): ");
            Console.WriteLine("--------------------------------------------------------------------------");

            string fruits = Console.ReadLine().ToLower();
            if ( fruits == "apple")
            {
                Console.WriteLine("price of apple is 6 TL");
            }
            else if ( fruits == "banana")
            {
                Console.WriteLine("price of banana is 8 TL");
            }
            else if (fruits == "orange")
            {
                Console.WriteLine("price of orange is 3 TL");
            }
            else if (fruits == "strawberry")
            {
                Console.WriteLine("price of strawberry is 2 TL");
            }
            else
            {
                Console.WriteLine("price of other fruits are 5 TL");
            }
            Console.ReadLine();
        }
    }
}
