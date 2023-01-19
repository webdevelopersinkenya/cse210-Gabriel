using System;

class Program
{
    static void Main(string[] args)
    {
       Console.Write("Enter Students Name : ");
       string Name = Console.ReadLine();

       Console.Write(" Enter English Grade :  ");
       double eng = Convert.ToDouble(Console.ReadLine());
       Console.Write(" Enter Maths Grade :  ");
       double math = Convert.ToDouble(Console.ReadLine());
       Console.Write(" Enter Kiswahili  Grade :  ");
       double kwsli = Convert.ToDouble(Console.ReadLine());
       Console.Write(" Enter Chemestry Grade :  ");
       double chem = Convert.ToDouble(Console.ReadLine());
        Console.Write(" Enter Physics Grade :  ");
       double physcs = Convert.ToDouble(Console.ReadLine());

       double average = (eng + math + kwsli + chem + physcs) / 5;

       if (average >= 75 )
       {
        Console.WriteLine(" The Student passed.");
       }
        else
       {
        Console.WriteLine(" The Student failed");
       }
    }
              
}      
