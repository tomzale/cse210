using System;

class Program
{
    // Note: 
    // - inheritance + polymorphism (Goal subclasses)
    // - encapsulation (private members)
    // - saving/loading via text file
    // - user can create goals and record events.
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        bool running = true;

        while (running)
        {
            ShowMenu();
            string choice = Console.ReadLine() ?? "";
            Console.WriteLine();

            switch (choice)
            {
                case "1":
                    CreateGoalMenu(manager);
                    break;
                case "2":
                    manager.ShowGoals();
                    break;
                case "3":
                    Console.Write("Enter filename to save: ");
                    string saveFile = Console.ReadLine() ?? "goals.txt";
                    manager.SaveToFile(saveFile);
                    break;
                case "4":
                    Console.Write("Enter filename to load: ");
                    string loadFile = Console.ReadLine() ?? "goals.txt";
                    manager.LoadFromFile(loadFile);
                    break;
                case "5":
                    if (manager.GetGoalCount() == 0)
                    {
                        Console.WriteLine("No goals to record.");
                        break;
                    }
                    manager.ShowGoals();
                    Console.Write("Enter goal number to record event for: ");
                    if (int.TryParse(Console.ReadLine(), out int idx))
                    {
                        manager.RecordEvent(idx);
                    }
                    else
                    {
                        Console.WriteLine("Invalid number.");
                    }
                    break;
                case "6":
                    Console.WriteLine($"Current score: {manager.GetScore()}");
                    break;
                case "7":
                    running = false;
                    Console.WriteLine("Good luck on your quest! Bye.");
                    break;
                default:
                    Console.WriteLine("Pick a number 1-7.");
                    break;
            }

            Console.WriteLine();
        }
    }

    static void ShowMenu()
    {
        Console.WriteLine("Eternal Quest - Main Menu");
        Console.WriteLine("1. Create a new goal");
        Console.WriteLine("2. Show goals");
        Console.WriteLine("3. Save goals to file");
        Console.WriteLine("4. Load goals from file");
        Console.WriteLine("5. Record an event (did a goal)");
        Console.WriteLine("6. Show score");
        Console.WriteLine("7. Quit");
        Console.Write("Choose: ");
    }

    static void CreateGoalMenu(GoalManager manager)
    {
        Console.WriteLine("Choose goal type:");
        Console.WriteLine("1. Simple goal (one-time)");
        Console.WriteLine("2. Eternal goal (repeat forever)");
        Console.WriteLine("3. Checklist goal (bonus at the end, You can Repeat This!)");
        Console.Write("Type 1-3: ");
        string t = Console.ReadLine() ?? "";
        Console.Write("Name: ");
        string name = Console.ReadLine() ?? "NoName";
        Console.Write("Short description: ");
        string desc = Console.ReadLine() ?? "";

        if (t == "1")
        {
            Console.Write("Points for completing: ");
            int pts = ReadIntFallback(100);
            manager.AddGoal(new SimpleGoal(name, desc, pts));
            Console.WriteLine("Simple goal added.");
        }
        else if (t == "2")
        {
            Console.Write("Points per event: ");
            int pts = ReadIntFallback(10);
            manager.AddGoal(new EternalGoal(name, desc, pts));
            Console.WriteLine("Eternal goal added.");
        }
        else if (t == "3")
        {
            Console.Write("Points per event: ");
            int pts = ReadIntFallback(10);
            Console.Write("Required times to finish: ");
            int req = ReadIntFallback(5);
            Console.Write("Completion bonus points: ");
            int bonus = ReadIntFallback(50);
            manager.AddGoal(new ChecklistGoal(name, desc, pts, req, bonus));
            Console.WriteLine("Checklist goal added.");
        }
        else
        {
            Console.WriteLine("Unknown type.");
        }
    }

    static int ReadIntFallback(int defaultVal)
    {
        string s = Console.ReadLine() ?? "";
        if (int.TryParse(s, out int v)) return v;
        return defaultVal;
    }
}
