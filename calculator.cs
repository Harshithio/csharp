using System;
class Calculator
{
    static void Main()
    {
        Console.WriteLine("Enter the number");
        int op = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("The operator number is" + op);

        Console.WriteLine("Enter two numbers");
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
       
        switch (op)
        {
            
            case 1:
                Console.WriteLine("Addition is" + (a + b));
                break;
            case 2:
                Console.WriteLine("Subtraction is" + (a - b));
                break;
            case 3:
                Console.WriteLine("Multiplication is" + (a * b));
                break;
            case 4:
                Console.WriteLine("Division is" + (a / b));
                break;
            case 5:
                Console.WriteLine("Modulus is" + (a % b));
                break;
            default:
                Console.WriteLine("other calculation");
                break;
        }
    }
