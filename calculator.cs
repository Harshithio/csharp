using System;
 class calculator
{
    static void Main()
    {
        Console.WriteLine("Enter two numbers");
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Addition is" + (a + b));
        Console.WriteLine("Subtraction is" + (a - b));
        Console.WriteLine("Multiplication is" + (a * b));
        Console.WriteLine("Division is" + (a / b));
        Console.WriteLine("Modulus is" + (a % b));

    }
}
