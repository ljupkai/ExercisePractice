/* a program that calculates the average of marks inserted by user */
using System;
public class Average
{
    public static void Main()
    {
        double a = 0, b, c = 0, d;
        string s;
        Console.Write("Insert a mark: ");
        s = Console.ReadLine(); 	 
        while (s != "end")
        {  
            b = Convert.ToDouble(s);
            c++;   
            a += b;  
            Console.Write("Insert a mark: ");
            s = Console.ReadLine();
        }
        if (c != 0)
        {
            d = a / c;  
            Console.WriteLine("The average is {0}.", d);
        }
    }
}
