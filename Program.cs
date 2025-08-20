using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        int numberToGuess = random.Next(1, 11); // number between 1 and 10
        int guess = 0;

        Console.WriteLine("🎲 Guess the number (between 1 and 10):");
        while (guess != numberToGuess)
        {
            Console.Write("Enter your guess: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out guess))
            {
                if (guess < numberToGuess)
                {
                    Console.WriteLine("Too low! Try again.");
                }
                else if (guess > numberToGuess)
                {
                    Console.WriteLine("Too high! Try again.");
                }
                else
                {
                    Console.WriteLine("🎉 Correct! You guessed the number!");
                }
            }
            else
            {
                Console.WriteLine("❌ Please enter a valid number.");
            }
        }
    }
}

//Test//
//Test2//






