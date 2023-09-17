using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        Console.WriteLine("What is your grade?");
        string input = Console.ReadLine();
        int x = int.Parse(input);
        string letter = "";

        if (x >= 90)
        {
            letter = "A";
        }
        else if (x >= 80)
        {
            letter = "B";
        }
        else if (x >= 70)
        {
            letter = "C";
        }
        else if (x > 59 && x < 70)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        };

        Console.WriteLine($"Your grade is: {letter}");

        if (x > 69)
        {
            Console.WriteLine("You passed the class!");
        }
        else
        {
            Console.WriteLine("You Failed. Better Luck Next Time.");
        };
    }
}