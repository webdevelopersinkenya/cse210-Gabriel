using System;

class Program
{
      DateTime theCurrentTime = DateTime.Now;
      
    static void Main(string[] args)
    { 
        DateTime  theCurrentTime = new DateTime();
        Console.WriteLine("Please select one of the following choices:");
        Console.WriteLine(" 1. write");
        Console.WriteLine(" 2. Display");
        Console.WriteLine(" 3. Load");
        Console.WriteLine(" 4. Save");
        Console.WriteLine(" 5. Quit");

        Console.WriteLine("What would you like to do today buddy?");
        string input = Console.ReadLine();
        string dateText = theCurrentTime.ToShortDateString();
        if(input == "write")
        {
          Console.WriteLine("What was the great part of your day? ");
          Console.ReadLine();
          
        }
        else
        {
            Console.WriteLine(" back to MENU?  ");
            Console.ReadLine();
            
        }
        if(input == "Display ")
        {
            Console.WriteLine( input);
        }
         
        
    }
}