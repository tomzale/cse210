using System;
using System.Threading;

public abstract class Activity
{
    protected string Name { get; set; }
    protected string Description { get; set; }
    protected int Duration { get; private set; }
    
    // Common starting sequence
    protected void DisplayStartMessage()
    {
        Console.Clear();
        Console.WriteLine($"Starting {Name}");
        Console.WriteLine(Description);
        Console.Write("Enter duration (seconds): ");
        Duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Prepare to begin...");
        ShowSpinner(3);
    }

    // Common ending sequence
    protected void DisplayEndMessage()
    {
        Console.WriteLine("Good job!");
        Console.WriteLine($"Completed {Name} for {Duration} seconds.");
        ShowSpinner(3);
    }
    
    // Reusable spinner animation
    protected void ShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds * 2; i++)
        {
            Console.Write("🌀 ");
            Thread.Sleep(500);
            Console.Write("\b\b");
        }
    }
    
    // Template method pattern
    public void Start()
    {
        DisplayStartMessage();
        RunActivity();
        DisplayEndMessage();
    }
    
    protected abstract void RunActivity();
}