using System.Collections.Generic;

public class ListingActivity : Activity
{
    private readonly List<string> _prompts = new()
    {
        "People you appreciate:",
        "Your personal strengths:",
        "Times you felt the Holy Ghost:"
    };

    public ListingActivity()
    {
        Name = "Listing Activity";
        Description = "List positive things in your life.";
    }

    protected override void RunActivity()
    {
        var random = new Random();
        Console.WriteLine(_prompts[random.Next(_prompts.Count)]);
        
        Console.WriteLine("Starting in...");
        ShowCountdown(5);
        
        var items = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(Duration);
        
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            items.Add(Console.ReadLine());
        }
        
        Console.WriteLine($"You listed {items.Count} items!");
    }

    private void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"{i} ");
            Thread.Sleep(1000);
        }
        Console.WriteLine("\nGo!");
    }
}