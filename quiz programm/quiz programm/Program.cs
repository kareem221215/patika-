using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz_programm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Correct_answers = 0;

            Console.WriteLine("which animal spits  when angry? ");
            Console.WriteLine("A) Llama B) Camel");
            string answer1 = Console.ReadLine().ToLower();
            switch (answer1)
            {
                case "a":
                case "llama":
                    Correct_answers++;
                    Console.WriteLine("Correct!!");
                    break;
                case "b":
                case "camel":
                    Console.WriteLine("Wrong, the correct answer was A) Llama :(");
                    break;
                default:
                    Console.WriteLine("Invalid answer! the correct asnwer was A) LLama");
                    break;
            }
            Console.WriteLine("your grade until now " + Correct_answers + "/3");

            Console.WriteLine("which planet is closest to the earth ");
            Console.WriteLine("A) Mars  B) Venus");
            string answer2 = Console.ReadLine().ToLower();
            switch (answer2)
            {
                case "b":
                case "venus":
                    Correct_answers++;
                    Console.WriteLine("Correct!!");
                    break;
                case "a":
                case "mars":
                    Console.WriteLine("Wrong, the correct answer was B) Venus :(");
                    break;
                default:
                    Console.WriteLine("Invalid answer! the correct asnwer was B) Venus");
                    break;
            }
            Console.WriteLine("your grade until now " + Correct_answers + "/3");

            if (Correct_answers < 1)
            {
                Console.WriteLine("you failed :( try again exiting in..");
                for (int i = 3; i >= 1; i--)
                {
                    Console.WriteLine(i);
                    Thread.Sleep(1000);
                }
                return;
            }

            Console.WriteLine("what is the answer to this equation 5*2+8/2-2 ");
            Console.WriteLine("A) 7  B) 12");
            string answer3 = Console.ReadLine().ToLower();
            switch (answer3)
            {
                case "b":
                case "12":
                    Correct_answers++;
                    Console.WriteLine("Correct!!");
                    break;
                case "a":
                case "7":
                    Console.WriteLine("Wrong, the correct answer was B) 12 :(");
                    break;
                default:
                    Console.WriteLine("Invalid answer! the correct asnwer was B) 12");
                    break;
            }
            Console.WriteLine("good job you got " + Correct_answers + "/3");

            if (Correct_answers >= 2)
            {
                Console.WriteLine($"Congratulations! You have won the grand prize of 1 Million TL! You answered {Correct_answers} questions correctly.");
            }
            else
            {
                Console.WriteLine($"Sorry, you didn't win the grand prize. You answered {Correct_answers} questions correctly.");
            }

            Console.ReadLine();
        }
    }
}