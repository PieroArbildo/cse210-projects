using System;

class Program
{
    static void Main(string[] args)
    {

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 100);
        int guessNumber=0;
        
        Console.WriteLine(magicNumber);
        
        while(magicNumber != guessNumber)
        {
            Console.WriteLine("What is your guess? ");
            guessNumber = int.Parse(Console.ReadLine());
            
            if (magicNumber > guessNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber == guessNumber)
            {
                Console.WriteLine("You guessed it!");
            }
            else
            {
                Console.WriteLine("Lower");
            }

        }

    }
}