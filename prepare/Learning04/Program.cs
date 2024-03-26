using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment asignacion1 = new Assignment("Samuel Bennett","Multiplication");
        Console.WriteLine(asignacion1.GetSummary());
        MathAssignment mathAsignacion1 = new MathAssignment("7.3","Problems 8-19","Roberto Rodriguez","Fractions");
        Console.WriteLine(mathAsignacion1.GetSummary());
        Console.WriteLine(mathAsignacion1.GetHomeworkList());

        WritingAssignment WritingAsignacion1 = new WritingAssignment("The Causes of World War II","Mary Waters","European History");
        Console.WriteLine(WritingAsignacion1.GetSummary());
        Console.WriteLine(WritingAsignacion1.GetWritingInformation());
    }
}