using System.Collections.Generic;

public class ReflectionActivity : Activity
{
    private readonly List<string> _prompts = new()
    {
        "Think of a time you stood up for someone.",
        "Recall a moment you overcame difficulty.",
        "Remember when you helped someone in need."
    };
    
    private readonly List<string> _questions = new()
    {
        "Why was this meaningful?",
        "How did you feel afterward?",
        "What did you learn about yourself?"
    };

    public ReflectionActivity()
    {
        Name = "Reflection Activity";
        Description = "Reflect on experiences of strength and resilience.";
    }

    protected override void RunActivity()
    {
        var random = new Random();
        Console.WriteLine(_prompts[random.Next(_prompts.Count)]);
        Console.WriteLine("Reflect on this experience...");
        ShowSpinner(5);

        DateTime endTime = DateTime.Now.AddSeconds(Duration);
        while (DateTime.Now < endTime)
        {
            Console.WriteLine(_questions[random.Next(_questions.Count)]);
            ShowSpinner(5);
        }
    }
}