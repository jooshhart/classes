using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");
        Account savings = new Account();
        savings._balance = 50;
        savings.Deposit(100);  
        Person p = new Person();
        p.SetFirstName("Peter");

        Console.WriteLine(p.GetFirstName());
        Person p = new Person(); 
        Person p1 = new Person(); 
        Person p2 = new Person("Jane", "Doe"); 
        Person p3 = new Person("Mrs.", "Jane", "Doe"); 
    }
}

public class Account
{
    private List<int> _transactions = new List<int>(); 

    public void Deposit(int amount)
    {
        _transactions.Add(amount);
    }
}

public class Person
{
    private string _title;
    private string _firstName;
    private string _lastName;

    public Person()
    {
        _title = "";
        _firstName = "Anonymous";
        _lastName = "Unknown";
    }

    public Person(string first, string last)
    {
        _title = "";
        _firstName = first;
        _lastName = last;
    }

    public Person(string title, string first, string last)
    {
        _title = title;
        _firstName = first;
        _lastName = last;
    }

}