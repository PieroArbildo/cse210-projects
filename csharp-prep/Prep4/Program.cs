using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>(); 

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        Console.Write("Enter number: ");
        int number = int.Parse(Console.ReadLine());
        numbers.Add(number);

        while (number != 0)
        {
            {   Console.Write("Enter number: ");
                number = int.Parse(Console.ReadLine());
                numbers.Add(number);
            }
        }

        numbers.RemoveAt(numbers.Count -1);

        int largest=0;
        foreach (int i in numbers)
        {
            if (i > largest)
            {
                largest = i;
            }
        }

          int sum = numbers.Sum();

          double avarage = numbers.Average();

          Console.WriteLine($"The sum is: {sum}");

          Console.WriteLine($"The average is: {avarage}");

          Console.WriteLine($"The largest number is {largest}"); 
       
    }
}