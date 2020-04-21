using System;

namespace SimpleShop1
{
    class Program
    {
        static string Ask(string question)
        {
            Console.Write(question + " ");
            return Console.ReadLine();
        }

        static double Price(int quantity)
        {
            double pricePerUnit;
            if (quantity >= 100)
            {
                pricePerUnit = 1.5;
            }
            else if (quantity >= 50)
            {
                pricePerUnit = 1.75;
            }
            else
            {
                pricePerUnit = 2;
            }
            return quantity * pricePerUnit;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the cat food store!");
            string entry = Ask("How many cans are you ordering?");
            int number = int.Parse(entry);
            double total = Price(number);
            Console.WriteLine($"You entered {number} cans, your total is: ${total}");
        }
    }
}
