using System;

class Journal
{
  
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program:");
        Console.WriteLine("Please  Select one of the following choices: ");
        Console.WriteLine(" 1. Write ");
        Console.WriteLine(" 2. Display ");
        Console.WriteLine(" 3. Load ");
        Console.WriteLine(" 4. Save ");
        Console.WriteLine(" 5. Quit");
        Console.WriteLine("What would you like to do today? ");
        string UserValue = Console.ReadLine();
        DateTime a  =  DateTime.Now;

        if(UserValue == "1")
        {
            string message = "If you had one thing you could do different today, what would it be? ";
            Console.WriteLine(message);
            string User = Console.ReadLine();

            Console.WriteLine(" What was the best part of your day? ");
            string Userinput = Console.ReadLine();
        }
            else if(UserValue == "2")
            {
            Console.WriteLine( a +  "prompt:" + UserValue);
            Console.ReadLine();
            }
        
        while (UserValue == "")
        {
        Console.WriteLine("Welcome to the Journal Program:");
        Console.WriteLine("Please  Select one of the following choices: ");
        Console.WriteLine(" 1. Write ");
        Console.WriteLine(" 2. Display ");
        Console.WriteLine(" 3. Load ");
        Console.WriteLine(" 4. Save ");
        Console.WriteLine(" 5. Quit");
        Console.WriteLine("What would you like to do today? ");
        
        }
        
    }
       
           

}
using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a base "Assignment" object
        Assignment a1 = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(a1.GetSummary());

        // Now create the derived class assignments
        MathAssignment a2 = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomeworkList());

        WritingAssignment a3 = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetWritingInformation());
    }
}