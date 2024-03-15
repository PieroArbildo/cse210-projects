using System;

class Program
{
    static void Main(string[] args)
    {
         Fraction numero1 = new Fraction();
        Console.WriteLine(numero1.GetFractionString());
        Console.WriteLine(numero1.GetDecimalValue());
    
        Fraction numero2 = new Fraction(5);   
        Console.WriteLine(numero2.GetFractionString());
        Console.WriteLine(numero2.GetDecimalValue());

        Fraction numero3 = new Fraction(3,4);   
        Console.WriteLine(numero3.GetFractionString());
        Console.WriteLine(numero3.GetDecimalValue());

        Fraction numero4 = new Fraction(1,3);   
        Console.WriteLine(numero4.GetFractionString());
        Console.WriteLine(numero4.GetDecimalValue());
    }
}