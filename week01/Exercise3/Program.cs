using System;

class Program
{
    static void Main(string[] args)
    {
        // We'll ask the user if they want to keep playing
        string playAgain;

        do
        {
            // Let the computer secretly pick a number between 1 and 100
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101);

            // This will store the user's guess
            int guess = -1;
            int guessCount = 0;

            Console.WriteLine("Welcome to 'Guess My Number'!");

            // Keep asking until the guess is correct
            while (guess != magicNumber)
            {
                Console.Write("What is your guess? ");
                string input = Console.ReadLine();
                guess = int.Parse(input); // Convert user input to a number
                guessCount++; // Count how many tries the user has taken

                // Give hints based on the guess
                if (guess < magicNumber)
                {
                    Console.WriteLine("Try a bit higher...");
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Too high. Try lower...");
                }
                else
                {
                    Console.WriteLine("Nice one! You guessed it 🎉");
                    Console.WriteLine($"You got it in {guessCount} guesses.");
                }
            }

            // Ask the user if they want to try again
            Console.Write("Do you want to play again? (yes/no): ");
            playAgain = Console.ReadLine();

        } while (playAgain.ToLower() == "yes"); // Keep playing if user says yes

        Console.WriteLine("Thanks for playing. Bye 👋");
    }
}
