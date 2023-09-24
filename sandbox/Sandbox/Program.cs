using System;

class Program
{
    static void Main(string[] args)
    {
        string[] prompt = {"What would you do differently today?", "Name two things you're grateful for today:", "Anything interesting happen today?"};
        System.Random random = new System.Random();
        string var = prompt[random.Next(0, prompt.Length)];
        Console.WriteLine($"{var}");
        string ans = Console.ReadLine();
        string writ = $"{var} + {ans}";
        Console.WriteLine(writ);
    }
}