using System;

class Program
{
    static void Main()
    {
        // Accept first number
        Console.Write("Enter First Number: ");
        string input1 = Console.ReadLine();
        double num1;
        if (!double.TryParse(input1, out num1))
        {
            Console.WriteLine("Invalid input! Please enter a valid number.");
            return;
        }

        // Accept second number
        Console.Write("Enter Second Number: ");
        string input2 = Console.ReadLine();
        double num2;
        if (!double.TryParse(input2, out num2))
        {
            Console.WriteLine("Invalid input! Please enter a valid number.");
            return;
        }

        // Accept operator
        Console.Write("Enter Operator (+, -, *, /): ");
        string op = Console.ReadLine();

        double result;
        bool valid = true;

        // Use switch-case for operation
        switch (op)
        {
            case "+":
                result = num1 + num2;
                break;
            case "-":
                result = num1 - num2;
                break;
            case "*":
                result = num1 * num2;
                break;
            case "/":
                if (num2 == 0)
                {
                    Console.WriteLine("Error: Division by zero is not allowed.");
                    return;
                }
                result = num1 / num2;
                break;
            default:
                Console.WriteLine("Invalid operator! Please use +, -, *, or /.");
                valid = false;
                result = 0; // placeholder
                break;
        }

        // Display result if valid
        if (valid)
        {
            Console.WriteLine($"Result: {result}");
        }
    }
}
