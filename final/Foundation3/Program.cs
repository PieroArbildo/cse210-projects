using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("100N", "Mayfield", "Utah","United States");
        Address address2 = new Address("Av.Benavides 2230", "Surco", "LIMA","Peru");
        Address address3 = new Address("Calle CH 123", "Mateh", "Buenos Aires","Argentina");
    
        Lecture lectureEvent1 = new Lecture("Lecture Title 1", "Lecture Description 1","20/06/24","13:25",address1, "feds Doe", 50);
        Reception receptionEvent1 = new Reception("Reception Title 2", "Reception Description 2", "12/12/24", "15:12", address2, "correorsp@example.com");
        OutdoorGathering outdoorEvent1 = new OutdoorGathering("Outdoor Gathering Title 3", "Outdoor Gathering Description 3", "13/02/25", "10:30", address3, "Sunny");

        Console.WriteLine("Standard Details:");
        Console.WriteLine(lectureEvent1.GetStandardDetails());
        Console.WriteLine("Full Details:");
        Console.WriteLine(lectureEvent1.GetFullDetails());
        Console.WriteLine("Short Description:");
        Console.WriteLine(lectureEvent1.GetShortDescription());
        Console.WriteLine();
    
        Console.WriteLine("Standard Details:");
        Console.WriteLine(receptionEvent1.GetStandardDetails());
        Console.WriteLine("Full Details:");
        Console.WriteLine(receptionEvent1.GetFullDetails());
        Console.WriteLine("Short Description:");
        Console.WriteLine(receptionEvent1.GetShortDescription());
        
        Console.WriteLine();
        Console.WriteLine("Short Description:");
        Console.WriteLine(outdoorEvent1.GetShortDescription());
        Console.WriteLine("Full Details:");
        Console.WriteLine(outdoorEvent1.GetFullDetails());
        Console.WriteLine("Short Description:");
        Console.WriteLine(outdoorEvent1.GetShortDescription());
    }
}