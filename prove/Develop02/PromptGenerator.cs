using System;

public class PromptGenerator
{
    public List<string> _prompts;
     public PromptGenerator()
    {
        _prompts = new List<string>();
    }
    public string GetRandomPrompt()
    {
        if (_prompts.Count > 0)
        {
            Random random = new Random();
            int index = random.Next(_prompts.Count);
            return (_prompts[index]);
        }
        else
        {
            return "have to create prompts";
        }
    }
}