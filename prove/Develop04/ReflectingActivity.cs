using System.Collections.Generic;
public class ReflectingActivity : Activity
{
            
    List<string> _question= new List<string>
    {
        ">How did you feel when it was complete?",
        ">What is your favorite thing about this experience?"
    };

    private List<string> _prompts = new List<string>
    {
        "	--- Think of a time when you did something really difficult. ---",
        "   ---Think of a time when you helped someone in need.---"
    };

 
    public ReflectingActivity(string name,string description):base( name, description)
    {
    }
    public void Run()
    {
        ShowCountDown(5);
        Console.WriteLine("Consider the following prompt:");
        GetRandomPrompt();
        GetRandomQuestion();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        ShowCountDown(5);
        Console.WriteLine(GetRandomQuestion());
        ShowSpinner(4);
        Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine(GetRandomQuestion());
        ShowSpinner(4);
        Console.ReadLine();
        Console.WriteLine();           
        DisplayEndingMessage();
        ShowSpinner(4);
        Console.WriteLine();
    }
    public string GetRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(_prompts.Count);
        return _prompts[index];
    }

    public string GetRandomQuestion()
    {
        Random rand2 = new Random();
        int index = rand2.Next(_question.Count);
        return _question[index];
    }

    public void DisplayPrompt()
    {
        Console.WriteLine(GetRandomPrompt());
    }
}