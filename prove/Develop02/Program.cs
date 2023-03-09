using System;

public enum GoalType
{
    Simple,
    Eternal,
    Checklist
}

public abstract class Goal
{
    public string Name { get; private set; }
    public GoalType GoalType { get; private set; }
    public int Reward { get; private set; }
    public int? Target { get; private set; }
    public int Completed { get; protected set; }

    public Goal(string name, GoalType goalType, int reward, int? target)
    {
        Name = name;
        GoalType = goalType;
        Reward = reward;
        Target = target;
        Completed = 0;
    }

    public abstract bool IsCompleted();

    public abstract void RecordEvent();

    public override string ToString()
    {
        if (GoalType == GoalType.Simple)
        {
            return $"{Name} ({Completed} / 1) [{Reward} points]";
        }
        else if (GoalType == GoalType.Eternal)
        {
            return $"{Name} ({Completed} times) [{Reward} points per time]";
        }
        else if (GoalType == GoalType.Checklist)
        {
            return $"{Name} ({Completed} / {Target} times) [{Reward} points per time, {Reward * Target} points bonus on completion]";
        }
        else
        {
            return "";
        }
    }
}

public class SimpleGoal : Goal
{
    public SimpleGoal(string name, int reward) : base(name, GoalType.Simple, reward, null) { }

    public override bool IsCompleted()
    {
        return Completed >= 1;
    }

    public override void RecordEvent()
    {
        Completed = 1;
    }
}

public class EternalGoal : Goal
{
    public EternalGoal(string name, int reward) : base(name, GoalType.Eternal, reward, null) { }

    public override bool IsCompleted()
    {
        return Completed > 0;
    }

    public override void RecordEvent()
    {
        Completed++;
    }
}

public class ChecklistGoal : Goal
{
    public ChecklistGoal(string name, int reward, int target) : base(name, GoalType.Checklist, reward, target) { }

    public override bool IsCompleted()
    {
        return Completed >= Target;
    }

    public override void RecordEvent()
    {
        Completed++;
    }
}

public class EternalQuest
{
    private List<Goal> goals;
    public int Score { get; private set; }

    public EternalQuest()
    {
        goals = new List<Goal>();
        Score = 0;
    }

    public void AddGoal(Goal goal)
    {
        goals.Add(goal);
    }

    public void RecordEvent(string goalName)
    {
        Goal goal = goals.Find(g => g.Name == goalName);
        if (goal != null)
        {
            goal.RecordEvent();
            Score += goal.Reward;
            if (goal.IsCompleted())
            {
                Score += goal.Reward * goal.Target.Value;
            }
        }
    }

    public void DisplayGoals()
    {
        foreach (Goal goal in goals)
        {
            string completedStr = goal.IsCompleted() ? "Completed" : "Not completed";
            if (goal.GoalType == GoalType.Checklist)
            {
                Console.WriteLine($"{goal}: {completedStr} ({goal.Completed}/{goal.Target})");
            }
            else
            {
                Console.WriteLine($"{goal}: {completedStr}");
            }
        }
    }
}


