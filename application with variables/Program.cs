using System;

namespace application_with_variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // bunch of Write lines and read lines to see text and accept texts from user
            Console.WriteLine("Please fill in the following questions: ");
            // added a sleeping thread so the user can read before starting the questions
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("TC number");
            long TC = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Your name: ");
            String First_name = Console.ReadLine();
            Console.WriteLine("Your Surname: ");
            String Last_name = Console.ReadLine();
            Console.WriteLine("Phone number: ");
            long P_Number = Convert.ToInt64(Console.ReadLine()); // conversion is needed so user can only input numbers and not letters + used (long) so user can put more integers
            Console.WriteLine("Your age: ");
            long age = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("First product Price: ");
            long First_product = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Second product Price: ");
            long Second_product = Convert.ToInt64(Console.ReadLine());
            long total = First_product + Second_product; // calculates the total prices  of the 2 products
            double discount = total * 0.1; // 10% discount is calculated
            double new_total = total - discount; //final price after the dicount is calculated
            // used double for both discount and new_total variables so that in case theres a decimal number itll  still work
            // prints the final output
            Console.WriteLine(First_name + Last_name + " Is registered with ID numbered " + TC);
            Console.WriteLine("A message has been sent to this number: " + P_Number);
            Console.WriteLine("Total product price: " + total);
            Console.WriteLine("10% discount has been added to your products, New price: " + new_total);




            Console.ReadLine();
        }
    }
}
