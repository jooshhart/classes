using System;

using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");
        List<int> numbers = new List<int>();

        int user = -1;
        while (user != 0)
        {
            Console.Write("Type a number (type 0 to finish): ");
            
            string response = Console.ReadLine();
            user = int.Parse(response);
        
            if (user != 0)
            {
                numbers.Add(user);
            }
        }
        int sum = 0;
        foreach (int x in numbers)
        {
            sum += x;
        }

        Console.WriteLine($"The sum is: {sum}");

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        int max = numbers[0];

        foreach (int x in numbers)
        {
            if (x > max)
            {
                max = x;
            }
        }

        Console.WriteLine($"The max is: {max}");

    }
}