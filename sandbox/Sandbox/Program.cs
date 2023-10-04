using System;

class Program
{
    static void Main(string[] args)
    {
        System.Random random = new System.Random();
        
        int count = 0;
        while(count!=20)
        {
            Console.WriteLine(Enumerable.Range(0,100).OrderBy(x => random.Next()).Take(20));
            count+=1;
        };
    }
}