using System;

class Program
{
    static void Main(string[] args)
    {
         Console.WriteLine("please select one of the following choices");
         Console.WriteLine("1. write");
         Console.WriteLine("2. Display");
         Console.WriteLine("3. Load");
         Console.WriteLine("4. Save");
         Console.WriteLine("5. Quit");

        Console.WriteLine("What would you like to do today? ");
         string input = Console.ReadLine();

        if (input == "write")
        {
            Console.WriteLine($" If I had one thing I could do today what would it be?  ");
            string Anwser =  Console.ReadLine();
            
            Console.WriteLine($"What was the best part of my day? ");
            Console.ReadLine();

        {
            
        }
            
        do
        {
         Console.WriteLine("please select one of the following choices");
         Console.WriteLine("1. write");
         Console.WriteLine("2. Display");
         Console.WriteLine("3. Load");
         Console.WriteLine("4. Save");
         Console.WriteLine("5. Quit");

        
        Console.WriteLine("What would you like to do today? ");
         string input1 = Console.ReadLine();
        } while (true); 
        }
    }
    

    
}