using System;
/* Input and outputs */
class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your Fisrt name? ");
        string FirstName = Console.ReadLine();

        Console.Write("What is your last name ?");
        string LastName = Console.ReadLine();

        Console.WriteLine($"Your  name is  {LastName},  {FirstName} {LastName} ");
        
        
    }
}