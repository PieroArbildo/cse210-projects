using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter you grade percentage: ");
        int gradePercentage = int.Parse(Console.ReadLine());
        Console.WriteLine(gradePercentage);
        string letter;

        if (gradePercentage >= 90)
        {
            letter="A";
        }
        else if (gradePercentage > 80)
        {
            letter="B";
        }
         else if (gradePercentage > 70)
        {
            letter="C";
        }
        else if (gradePercentage >= 60)
        {
            letter="D";
        }
        else
        {
            letter="F";
        }

        /*add + or -*/
        int last_digit = gradePercentage % 10;

        string sign="";

        if (letter =="A" && last_digit > 7)
        {
            sign = "";
        }
        else if (letter =="F" )
        {
            sign = "";
        }

        else if (last_digit > 7)
        {
            sign = "+";
        }
        else if (last_digit < 3)
        {
            sign = "-";
        }

        Console.WriteLine($"{letter}{sign}");

        if (gradePercentage >= 70)
        {
            Console.WriteLine("Congratulations, you passed the course.");
        }
        else
        {
            Console.WriteLine("You have not passed the course");
        }
        
    }
}