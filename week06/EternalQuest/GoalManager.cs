using System;
using System.Collections.Generic;
using System.IO;

// Manages the goals and the total score. Handles save/load.
public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    public void AddGoal(Goal g) => _goals.Add(g);
    public int GetScore() => _score;

    public void ShowGoals()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals yet.");
            return;
        }

        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetStatusString()}");
        }
    }

    // record an event for goal index (1-based in UI)
    public void RecordEvent(int index)
    {
        if (index < 1 || index > _goals.Count)
        {
            Console.WriteLine("Invalid goal number.");
            return;
        }

        Goal g = _goals[index - 1];
        int earned = g.RecordEvent();
        _score += earned;

        Console.WriteLine($"You earned {earned} points.");
        Console.WriteLine($"Current score: {_score}");
    }

    // Save to file: first line Score:123, then each goal line
    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine($"Score:{_score}");
            foreach (var g in _goals)
            {
                writer.WriteLine(g.GetStringRepresentation());
            }
        }
        Console.WriteLine("Saved.");
    }

    // Load from file (replace any existing goals)
    public void LoadFromFile(string filename)
    {
        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }

        string[] lines = File.ReadAllLines(filename);
        if (lines.Length == 0)
        {
            Console.WriteLine("File empty.");
            return;
        }

        _goals.Clear();
        _score = 0;

        foreach (string line in lines)
        {
            if (line.StartsWith("Score:"))
            {
                string num = line.Substring("Score:".Length);
                _score = int.Parse(num);
            }
            else
            {
                Goal g = Goal.CreateFromString(line);
                _goals.Add(g);
            }
        }

        Console.WriteLine("Loaded.");
    }

    // Allow getting number of goals (useful for UI)
    public int GetGoalCount() => _goals.Count;
}
