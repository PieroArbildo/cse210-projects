using System.Collections.Generic;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;
    private List<SimpleGoal> _simpleGoals = new List<SimpleGoal>();
    private List<EternalGoal> _eternalGoals = new List<EternalGoal>();
    private List<ChecklistGoal> _checklistGoals = new List<ChecklistGoal>();
    public GoalManager()
    {
        _score=0;
        Start();  
    }
    public void Start()
    {
        Console.WriteLine();
        Console.WriteLine($"You have {_score} points.");
        Console.WriteLine("Menu Options:");
        Console.WriteLine("  1. Create New Goal");
        Console.WriteLine("  2. List Goals");
        Console.WriteLine("  3. Save Goals");
        Console.WriteLine("  4. Load Goals");
        Console.WriteLine("  5. Record Event");
        Console.WriteLine("  6. Quit");
        Console.Write("Select a choice from the menu: " );
        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                  ListGoalNames();
                  CreateGoal();
                break;
            case 2:
                       Console.WriteLine("The goals are:");
                        foreach (SimpleGoal goal in _simpleGoals)
                        {
                            Console.WriteLine(goal.GetStringRepresentation());
                        }
                        foreach (EternalGoal goal in _eternalGoals)
                        {
                            Console.WriteLine(goal.GetStringRepresentation());
                        }
                        foreach (ChecklistGoal goal in _checklistGoals)
                        {
                            Console.WriteLine(goal.GetStringRepresentation());
                        }
                        Console.WriteLine();
                        Start();
                        break;
            case 3:
                    SaveGoal("goal.csv");
                    Console.WriteLine("You have saved a csv file");
                    Start();
                break;
            case 4:
                LoadGoal("goal.csv");
                break;
            case 5:                       
                        foreach (SimpleGoal goal in _simpleGoals)
                        {
                            Console.Write("1. ");
                            goal.GetShortName();
                        }
                        foreach (EternalGoal goal in _eternalGoals)
                        {
                            Console.Write("2. ");
                            goal.GetShortName();
                        }
                        foreach (ChecklistGoal goal in _checklistGoals)
                        {
                            Console.Write("3. ");
                            goal.GetShortName();
                        }
                        Console.Write("Which goal did you accomplish? ");
                        int choseCompleted = int.Parse(Console.ReadLine());
                
                        if (choseCompleted ==1)
                        {
                            SimpleGoal selectedGoal = _simpleGoals[0];
                            selectedGoal.RecordEvent();
                            selectedGoal.IsComplete(true);
                            _score = _score + selectedGoal.GetPoints();
                            Console.WriteLine($"Congratulation you have earned {selectedGoal.GetPoints()} points!");
                            Start();
                        }
                        else if (choseCompleted == 2)
                        {
                            EternalGoal selectedGoal2 = _eternalGoals[0];
                            _score = _score + selectedGoal2.GetPoints();
                            Console.WriteLine($"Congratulation you have earned {selectedGoal2.GetPoints()} points!");
                            Start();
                        }
                        else if (choseCompleted == 3)
                        {
                            ChecklistGoal selectedGoal3 = _checklistGoals[0];
                            selectedGoal3.IncreaseAmount();
                            _score = _score + selectedGoal3.GetPoints();
                            Console.WriteLine($"Congratulation you have earned {selectedGoal3.GetPoints()} points!");
                            if (selectedGoal3.IsComplete())
                            {
                                _score = _score + selectedGoal3.GetBonus();
                            }
                            Start();
                        }                
                break;
            case 6:
                break;
            default:
                Console.WriteLine("Enter a number between 1 and 6.");
                break;
        }
    }
    public void DisplayPlayerInfo()
    {
        Console.WriteLine(_score);
    }
    public void ListGoalNames()
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");
    }
    public void CreateGoal()
    {
        int choice2 = int.Parse(Console.ReadLine());
        
        if (choice2 == 1)
        {
            Console.Write("What is the name of your Goal? ");
            string name = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            string description = Console.ReadLine();
            Console.Write("What is the amount of points assosiate with this goal? ");
            string points = Console.ReadLine();
            SimpleGoal simpleGoal = new SimpleGoal(name,description, points);
            Console.WriteLine(simpleGoal.GetDetailString());
            _simpleGoals.Add(simpleGoal); 
            Start();
        }
        else if (choice2 == 2)
        {
            Console.Write("What is the name of your Goal? ");
            string name = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            string description = Console.ReadLine();
            Console.Write("What is the amount of points assosiate with this goal? ");
            string points = Console.ReadLine();
            EternalGoal eternalGoal = new EternalGoal(name,description, points);
            Console.WriteLine(eternalGoal.GetDetailString());
            _eternalGoals.Add(eternalGoal);
            Start();
        }
        else if (choice2 == 3)
        {
            Console.Write("What is the name of your Goal? ");
            string name = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            string description = Console.ReadLine();
            Console.Write("What is the amount of points assosiate with this goal? ");
            string points = Console.ReadLine();
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("What is the bonus for accomplishing it that many times? ");
            int bonus = int.Parse(Console.ReadLine());
            ChecklistGoal checklistGoal = new ChecklistGoal(target,bonus,name,description, points);
            Console.WriteLine(checklistGoal.GetDetailString());
            _checklistGoals.Add(checklistGoal); 
            Start();
        } 
    }

    public void SaveGoal(string file)
    {
        using (StreamWriter writer = new StreamWriter(file))
        {
           writer.WriteLine(_score);
           foreach (SimpleGoal goal in _simpleGoals)
            {
                writer.WriteLine(goal.ToSave());
            }
            foreach (EternalGoal goal in _eternalGoals)
            {  
                writer.WriteLine(goal.ToSave());
            }
            foreach (ChecklistGoal goal in _checklistGoals)
            {  
                writer.WriteLine(goal.ToSave());
            }
        }
    }
    public void LoadGoal(string file)
    {
        string[] lineas = File.ReadAllLines(file);
        _score = int.Parse(lineas[0]);
        for (int i = 1; i < lineas.Length; i++)
        {
            string[] elementos = lineas[i].Split(',');
            switch (elementos[0])
            {
                case "SimpleGoal":
                    _simpleGoals.Add(new SimpleGoal(elementos[1], elementos[2], elementos[3])); 
                    break;
                case "EternalGoal":
                     _eternalGoals.Add(new EternalGoal(elementos[1], elementos[2], elementos[3])); 
                    break;
                case "ChecklistGoal":
                int metaActual = int.Parse(elementos[3]);
                int totalMetas = int.Parse(elementos[4]);
                int puntajeMaximo = int.Parse(elementos[5]);
                int puntajePorElemento = int.Parse(elementos[6]);
                _checklistGoals.Add(new ChecklistGoal(totalMetas, puntajeMaximo, elementos[1], elementos[2], elementos[3]));
                    break;          
            }        
        }
        Console.WriteLine("The data was loaded");
        Start();   
    }   
}