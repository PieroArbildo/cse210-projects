using System;

class Program
{
  
        static void Main(string[] args)
        {
            DisplayWelcome();
   
            DisplayResult(PromptUserName(),SquareNumber(PromptUserNumber()));
        }
        

        static void  DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }

        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string userName = Console.ReadLine();
            return userName;
        }

        static int PromptUserNumber()
        {
            Console.WriteLine("Please enter your favorite number: ");
            int number = int.Parse(Console.ReadLine());
            return number;
        }

        static int SquareNumber(int value)
        {
            return value*value;

        }

        static void DisplayResult(string name, int value)
        {
            Console.WriteLine($"Brother {name}, the square of your number is {value}");
        }
    
}