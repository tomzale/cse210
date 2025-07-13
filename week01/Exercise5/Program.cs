using System;

class Program
{
    static void Main(string[] args)
    {
        // Start by showing a welcome message
        DisplayWelcome();

        // Ask for the user's name
        string userName = PromptUserName();

        // Ask for their favorite number
        int favoriteNumber = PromptUserNumber();

        // Square the number
        int squaredNumber = SquareNumber(favoriteNumber);

        // Show the result
        DisplayResult(userName, squaredNumber);
    }

    // Simple function to show a welcome message
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    // Ask for the user's name and return it
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    // Ask for the user's favorite number and return it as an integer
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string input = Console.ReadLine();
        int number = int.Parse(input);
        return number;
    }

    // A function to square any number you give it
    static int SquareNumber(int number)
    {
        return number * number;
    }

    // Nicely show the final message
    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
}
