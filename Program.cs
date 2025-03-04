using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int targetNumber = random.Next(1, 101); // Random number between 1 and 100
            int guess = 0;
            int attempts = 0;

            Console.WriteLine("Welcome to the Guess the Number game!");
            Console.WriteLine("I've selected a number between 1 and 100. Try to guess it!");

            while (guess != targetNumber)
            {
                Console.Write("Enter your guess: ");
                string input = Console.ReadLine();

                if (!int.TryParse(input, out guess)) // Validate input
                {
                    Console.WriteLine("Invalid input! Please enter a number.");
                    continue;
                }

                attempts++;

                if (guess < targetNumber)
                {
                    Console.WriteLine("Too low! Try again.");
                }
                else if (guess > targetNumber)
                {
                    Console.WriteLine("Too high! Try again.");
                }
                else
                {
                    Console.WriteLine($"Congratulations! You guessed the number {targetNumber} in {attempts} attempts.");
                }
            }

            Console.WriteLine("Thanks for playing!");
        }
    }
}
