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

        static string GetName()
        {
            return Ask("What is your name?");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the cat food store!");

            string name = GetName();
            
            string entry = Ask("How many cans are you ordering?");
            int number;
            
            // Handling invalid input for the number of cans
            while (!int.TryParse(entry, out number))
            {
                Console.WriteLine("Please enter a valid number.");
                entry = Ask("How many cans are you ordering?");
            }

            double total = Price(number);
            Console.WriteLine($"Hi {name}, you entered {number} cans, your total is: ${total}");

            string feedback = Ask("Did you like our service? (Yes/No)");

            // Handling different feedback responses
            if (feedback.ToLower() == "yes")
            {
                Console.WriteLine($"Thank you for your positive feedback, {name}!");
            }
            else if (feedback.ToLower() == "no")
            {
                Console.WriteLine($"We're sorry to hear that, {name}. We'll strive to improve!");
            }
            else
            {
                Console.WriteLine($"Your response '{feedback}' is not recognized. Please provide Yes or No.");
            }
        }
    }
}
