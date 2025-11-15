using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter an integer:");
        string input = Console.ReadLine();  
        int sum = 0;
        
        foreach (char digitChar in input)
        {
            
            sum += int.Parse(digitChar.ToString());
        }

        Console.WriteLine($"Sum: {sum}");  
    }
}