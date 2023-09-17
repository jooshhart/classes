using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");
        Random randomGenerator = new Random();
        int magic = randomGenerator.Next(1, 101);
        int guess = -1;
        while (guess != magic)
        {
            Console.WriteLine("Guess the magic number");
            guess = int.Parse(Console.ReadLine());
            if (magic > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (magic < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You Guessed It!");
            }
        };
    }
}