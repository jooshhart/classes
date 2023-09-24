using System;
using System.Formats.Asn1;
using System.Runtime.InteropServices;
using System.Threading.Tasks.Dataflow;
using Microsoft.VisualBasic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("");
        Console.WriteLine("Welcome to the Journal App");
        Console.WriteLine("");

        string choice = "";
        string[] dis = {};

        while (choice != "5")
        {
            Console.WriteLine("Select one of the following choices:\n1. Write\n2. Display\n3. Load\n4. Save\n5. Quit");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                string[] prompt = {"What would you do differently today?", "Name two things you're grateful for today:", "Anything interesting happen today?"};
                System.Random random = new System.Random();
                string var = prompt[random.Next(0, prompt.Length)];
                Console.WriteLine($"{var}");
                string ans = Console.ReadLine();
                DateTime theCurrentTime = DateTime.Now;
                string dateText = theCurrentTime.ToShortDateString();
                string writ = $"{var} {ans}\n{dateText}";
                dis = dis.Append(writ).ToArray();
            }
            else if (choice == "2")
            {
                Console.WriteLine(dis);
            }
            else if (choice == "3")
            {
                Chooseload choose = new Chooseload();
                dis = dis.Append(choose.ReadFromFile()).ToArray();
            }
            else if (choice == "4")
            {
                Console.WriteLine("What's the name of the save file?");
                string filename = Console.ReadLine();

                using (StreamWriter outputFile = new StreamWriter(filename))
                {
                    Console.WriteLine(dis);
                };
                Array.Clear(dis, 0, dis.Length);
            }
            else if (choice == "5")
            {
                Console.WriteLine("Have a nice day!");
            };
        };
        
    }
}


abstract class Chooseload
{
    public static List<> ReadFromFile()
    {
        Console.WriteLine("Choose which file: ");
        string load = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(load);

        foreach (string line in lines)
        {
            string[] parts = line.Split(",");
            return parts;
        }
    }
}

class Loader:Chooseload
{
    
}