using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcomeMessage();

        string name = Promptname();
        int number = Promptnumber();

        int squared = square(number);

        result(name, squared);
    }

    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string Promptname()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        return name;
    }

    static int Promptnumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());

        return number;
    }

    static int square(int number)
    {
        int square = number * number;
        return square;
    }

    static void result(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
}