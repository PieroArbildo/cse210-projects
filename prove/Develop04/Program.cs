using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        bool continuar = true;
        while(continuar)
        {
            Console.WriteLine("Menu options:");
            Console.WriteLine(" 1. Start breathing activity");
            Console.WriteLine(" 2. Start Reflecting activity");
            Console.WriteLine(" 3. Start Listing activity");
            Console.WriteLine(" 4. Quit");
            Console.Write("Select choice from the menu: ");
            int number = int.Parse(Console.ReadLine());
            if (number ==4)
            {
                break;
            }

            switch (number)
            {
                case 1:
                    BreathingActivity actividad1 = new BreathingActivity("Breathing","This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing");
                    actividad1.DisplayStartingMessage();
                    actividad1.ShowSpinner(3);
                    Console.WriteLine("Get ready...");
                    actividad1.Run();

                    /*actividad1.ShowCountDown(5);*/
                    actividad1.ShowSpinner(3);
                    actividad1.DisplayEndingMessage();
                    break;
                case 2:
                    ReflectingActivity activity2 = new ReflectingActivity("Reflecting","This activity will help you reflect on times in your life when you have shown strenght and resilience. this will help you recognize the power you have and how you can use it in other aspects of your life.");
                    activity2.DisplayStartingMessage();
                    activity2.ShowSpinner(3);
                    Console.WriteLine("Get ready...");
                    activity2.Run();
                    break;
                case 3:
                    ListingActivity activity3 = new ListingActivity("Listing","This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area");
                    activity3.DisplayStartingMessage();
                    Console.WriteLine("Get ready...");
                    activity3.ShowSpinner(3);
                    Console.WriteLine("Get ready...");
                    activity3.Run();
                    break;
                case 4:
                    Console.WriteLine("leaving the program");
                    break;
                default:
                    Console.WriteLine("Enter a number from 1 to 4.");
                    break;
            }  
        }
    }
}