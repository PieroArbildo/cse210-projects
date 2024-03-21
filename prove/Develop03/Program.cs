using System;

class Program
{
    static void Main(string[] args)
    {
        Reference referencia1 = new Reference("Mosiah ",27,4);

        List<Word> words = new List<Word>();
        
        words.Add(new Word("That"));
        words.Add(new Word("they"));
        words.Add(new Word("should"));
        words.Add(new Word("let"));
        words.Add(new Word("no"));
        words.Add(new Word("pride"));
        words.Add(new Word("nor"));
        words.Add(new Word("haughtiness"));
        words.Add(new Word("disturb"));
        words.Add(new Word("their"));
        words.Add(new Word("peace"));
        words.Add(new Word("that"));
        words.Add(new Word("every"));
        words.Add(new Word("man"));
        words.Add(new Word("should"));
        words.Add(new Word("esteem"));
        words.Add(new Word("his"));
        words.Add(new Word("neighbor"));
        words.Add(new Word("as"));
        words.Add(new Word("himself"));
        words.Add(new Word("laboring"));
        words.Add(new Word("with"));
        words.Add(new Word("their"));
        words.Add(new Word("own"));
        words.Add(new Word("hands"));
        words.Add(new Word("for"));
        words.Add(new Word("their"));
        words.Add(new Word("support"));
        

        Scripture scripture = new Scripture(referencia1, words);

        // show the full passage
        Console.WriteLine(scripture.GetDisplayText());


        scripture.HideRandomWords(4);

        string input = Console.ReadLine().ToLower();
        while(input != "quit")
        {
            if (!Console.IsOutputRedirected)
            {
                Console.Clear();
            }
  
            // Hide words per loop iteration
            scripture.HideRandomWords(4);

            // Show the modified passage
            Console.WriteLine(scripture.GetDisplayText());

            if (scripture.IsCompletelyHidden())
            {
                break;
            }
            
            input = Console.ReadLine().ToLower();
        }
    }
}