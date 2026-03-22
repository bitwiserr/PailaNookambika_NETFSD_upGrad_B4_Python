using System;

class Calculator
{
    // Divide method with exception handling
    public double Divide(int numerator, int denominator)
    {
        try
        {
            // Attempt division
            return numerator / denominator;
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Error: Cannot divide by zero");
            return double.NaN; // return a safe value
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Unexpected error: {ex.Message}");
            return double.NaN;
        }
        finally
        {
            Console.WriteLine("Operation completed safely");
        }
    }
}

class Program
{
    static void Main()
    {
        Calculator calc = new Calculator();

        // Sample Input
        int numerator = 20;
        int denominator = 0;

        double result = calc.Divide(numerator, denominator);

        // Display result only if valid
        if (!double.IsNaN(result))
        {
            Console.WriteLine($"Result = {result}");
        }

        // Continue execution after error
        Console.WriteLine("Program continues running...");
    }
}
