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

        string table = "What would you like to do today? ";
        string Values = " Please  choose from the Values 1, 2, 3, 4, 5 for your actions:";
        Console.WriteLine(table);
        Console.WriteLine(Values);
        string UserValue = Console.ReadLine();

        if (UserValue == " 1")
        {
          string message = "What was the best part of the day today? ";
          Console.WriteLine(message);
        
        }
        else if(UserValue == " 2")
        {
            string message = " What part of the day did you love?";
            Console.WriteLine(message);
            
        }
        else if(UserValue == "3")
        {
        string message = "What would you like to do with your information";
        Console.WriteLine(message);
        
        }
        else if(UserValue == "4")
        {
            string message = "Do you want to SAVE  OR CONTINUE? ";
            Console.WriteLine(message);
        
        }
        else if(UserValue == "5")
         {
            string message = "Do you wish to Quit?";
            Console.WriteLine(message);
            
         }
        
        else
        {
          string message =  "Sorry I dont understand your type value:";
          Console.WriteLine(message);
        }
          Console.ReadLine();

    }   


}       
         
        
    
        
    
       

    
