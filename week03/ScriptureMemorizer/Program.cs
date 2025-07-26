using System;

class Program
{
   
// Submission Notes:
// This week was a little tight for me but I still enjoyed working on this one.
// I picked a verse from 2 Nephi that really means something to me as a return missionary.
// Hiding 3 words per round gave it a good pace for practice.


    static void Main(string[] args)
    {
        Console.Clear();

        // Return missionary vibes 📖
        Reference reference = new Reference("2 Nephi", 2, 25);
        string verseText = "Adam fell that men might be; and men are, that they might have joy.";

        Scripture scripture = new Scripture(reference, verseText);

        // Keep running until all words hidden or user quits
        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress Enter to hide more words or type 'quit' to exit.");
            Console.Write("> ");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                Console.WriteLine("\nThanks for memorizing. Goodbye 👋");
                break;
            }

            scripture.HideRandomWords(3); // hide 3 words per round 

            if (scripture.AllWordsHidden())
            {
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine("\nWell done! All words are now hidden 🎉");
                break;
            }
        }
    }
}
