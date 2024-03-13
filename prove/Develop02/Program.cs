using System;

class Program
{
    static void Main(string[] args)
    {
         PromptGenerator value = new PromptGenerator();
        value._prompts.Add("How do you feel today?");
        value._prompts.Add("What did you do today?");
        value._prompts.Add("What did you eat today?");
        value._prompts.Add("Today was there anything important that you would like to highlight?");
        value._prompts.Add("Did you see someone special today?");
    
        int number =0;
        Journal myJournal = new Journal();
        Entry entrada = null;
        string filename;

        while (number != 5)
        {   
            Console.WriteLine("Welcome to the Journal program!\nPlease select one of the following choices:\n1. Write\n2. Display\n3. Load\n4. Save\n5. Quit\nWhat would you like to do? ");
             number  = int.Parse(Console.ReadLine());
             switch (number)
             {
                case 1:
                   
                   entrada = new Entry();
                    entrada._date = DateTime.Now.ToShortDateString();
                    entrada._promptText = value.GetRandomPrompt();
                    Console.WriteLine(entrada._promptText);
                    entrada._entryText = Console.ReadLine();
                    
                    myJournal.AddEntry(entrada);
                    break;
                case 2:
                    myJournal.DisplayAll();
                    Console.WriteLine("");
                    break;
                case 3:
                       try
                        {
                            Console.WriteLine("Enter the filename: ");
                            filename = Console.ReadLine();
                            myJournal.LoadToFile(filename);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Write you filename correctly " + ex.Message);
                        }
                    break;
                case 4:
                    if (entrada != null)
                    {
                        // Obtener el nombre del archivo del usuario
                        Console.WriteLine("Write a filename:");
                        filename = Console.ReadLine();

                        myJournal._promptText = entrada._promptText;
                        myJournal._entryText = entrada._entryText;
                        myJournal._date = entrada._date;
                        myJournal.SaveToFile(filename);
                    }
                    else
                    {
                        Console.WriteLine("You must first enter an entry.");
                    }
                    break;
                case 5:
                    Console.WriteLine("Exiting the program");
                    break;
                default:
                    Console.WriteLine("Invalid option");
                    break;
             }
        }
    }
}