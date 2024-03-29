using System.Collections.Generic;
public class ListingActivity : Activity
{
    private int _count;        private List<string> _prompts = new List<string>
    {
        "   ---When you felt the Holy Ghost this month? ---",
        "   ---When you felt Happiness this month? ---"
    };

    public ListingActivity(string name,string description):base( name, description)
    {
    }

    public void Run()
    {   
        GetRandomPrompt();
        ShowCountDown(5);
        GetListFromUser();
        Console.WriteLine(" ");
        Console.WriteLine($"You listed 4 items!");
        DisplayEndingMessage();
    }

    public void GetRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(_prompts.Count);
        Console.WriteLine(_prompts[index]);
    }
        
    public List<string> GetListFromUser()
    {
        List<string> inputs = new List<string>();
        for (int i = 0; i < 4; i++)
        {
            Console.WriteLine();
            Console.Write(">");
            string input = Console.ReadLine();
            inputs.Add(input);
        }
        return inputs;
    }     
}