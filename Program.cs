using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        string input = Console.ReadLine();          
        int number = int.Parse(input);             

        int square = number * number;
        Console.WriteLine("Square of " + number + " is " + square);
    }
}

