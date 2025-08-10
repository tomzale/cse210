using System;

// Base class for all goals
public abstract class Goal
{
    private string _name;
    private string _description;

    public Goal(string name, string description)
    {
        _name = name;
        _description = description;
    }

    // public getters (member vars stay private)
    public string GetName() => _name;
    public string GetDescription() => _description;

    // return points gained when an event is recorded
    public abstract int RecordEvent();

    // is this goal complete? (eternal goals return false)
    public abstract bool IsComplete();

    // nice display text for listing
    public abstract string GetStatusString();

    // convert to a string to save to file
    public abstract string GetStringRepresentation();

    // Factory: create correct goal subclass from the saved string
    // Format examples:
    // Simple: Simple|name|description|points|isComplete
    // Eternal: Eternal|name|description|points
    
    public static Goal CreateFromString(string line)
    {
        string[] parts = line.Split('|');
        string type = parts[0];
        if (type == "Simple")
        {
            string name = parts[1];
            string desc = parts[2];
            int points = int.Parse(parts[3]);
            bool isComplete = bool.Parse(parts[4]);
            var g = new SimpleGoal(name, desc, points);
            if (isComplete && !g.IsComplete())
            {
                // mark as already complete w/o awarding points
                g.ForceComplete();
            }
            return g;
        }
        else if (type == "Eternal")
        {
            string name = parts[1];
            string desc = parts[2];
            int points = int.Parse(parts[3]);
            return new EternalGoal(name, desc, points);
        }
        else if (type == "Checklist")
        {
            string name = parts[1];
            string desc = parts[2];
            int pointsPer = int.Parse(parts[3]);
            int required = int.Parse(parts[4]);
            int current = int.Parse(parts[5]);
            int bonus = int.Parse(parts[6]);
            bool isComplete = bool.Parse(parts[7]);
            var g = new ChecklistGoal(name, desc, pointsPer, required, bonus);
            g.ForceSetCurrent(current);
            if (isComplete && !g.IsComplete())
            {
                g.ForceComplete();
            }
            return g;
        }
        else
        {
            throw new Exception("Unknown goal type in saved file.");
        }
    }
}
