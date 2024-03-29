using System.Collections.Generic;
public class Activity
{
    private string _name;
    private string _description;
    protected  int _duration;

    public Activity(string name,string description )
    {
        _name = name;
        _description = description;
    }
    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name} Activity");
        Console.WriteLine($"{_description}" );
        Console.Write($"How long in seconds, would you like for you session? ");
        _duration = int.Parse(Console.ReadLine());
    }
    public void DisplayEndingMessage()
    {
         Console.WriteLine("Well done");
         Console.WriteLine($"You have completed another {_duration} seconds of the {_name} Activity");
    }
    public void ShowSpinner(int seconds)
    {
        List<string> animationString = new List<string> { "|", "/","-","\\","|", "/","-","\\" };
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);
        int i = 0;

        while (DateTime.Now < endTime)
        {
            string s = animationString[i];
            Console.Write(s);
            Thread.Sleep(600);
            Console.Write("\b \b");
            i++;
            if (i> animationString.Count)
            {
                i=0;
            }
        }
    }

    public void ShowCountDown(int seconds)
    {
        Console.Write("You may begin in: ");
        for (int i = seconds; i>0 ; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}