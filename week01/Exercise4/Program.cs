using System;
using System.Collections.Generic; // This lets us use lists

class Program
{
    static void Main(string[] args)
    {
        // We'll store all the numbers the user enters in this list
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers. Type 0 when you're done.");

        int number = -1; // Just need something that's not 0 to get the loop started

        // Keep asking for numbers until the user types 0
        while (number != 0)
        {
            Console.Write("Enter number: ");
            string input = Console.ReadLine();
            number = int.Parse(input);

            if (number != 0)
            {
                numbers.Add(number); // We only add it if it's not 0
            }
        }

        // Now let’s do a few things with the list:

        // 1. Add up all the numbers
        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }

        // 2. Find the average (as a float so it’s more accurate)
        float average = (float)sum / numbers.Count;

        // 3. Find the biggest number in the list
        int max = numbers[0]; // Start by assuming the first number is the biggest
        foreach (int num in numbers)
        {
            if (num > max)
            {
                max = num;
            }
        }

        // Print out the results
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}");
    }
}
