using System;

class Program
{
    // ✅ Method returning Tuple (Sales, Rating)
    static (double Sales, int Rating) GetPerformanceData(double sales, int rating)
    {
        return (sales, rating);
    }

    // ✅ Method to evaluate performance using pattern matching
    static string EvaluatePerformance((double Sales, int Rating) data)
    {
        return data switch
        {
            (>= 100000, >= 4) => "High Performer",
            (>= 50000, >= 3) => "Average Performer",
            _ => "Needs Improvement"
        };
    }

    static void Main()
    {
        Console.Write("Enter Employee Name: ");
        string name = Console.ReadLine()!;

        Console.Write("Enter Monthly Sales Amount: ");
        if (!double.TryParse(Console.ReadLine(), out double sales) || sales < 0)
        {
            Console.WriteLine("Invalid Sales Amount.");
            return;
        }

        Console.Write("Enter Customer Feedback Rating (1–5): ");
        if (!int.TryParse(Console.ReadLine(), out int rating) || rating < 1 || rating > 5)
        {
            Console.WriteLine("Invalid Rating. Must be between 1 and 5.");
            return;
        }

        // Get tuple data
        var performanceData = GetPerformanceData(sales, rating);

        // Evaluate performance
        string category = EvaluatePerformance(performanceData);

        // Display results
        Console.WriteLine("\n--- Employee Performance Report ---");
        Console.WriteLine($"Employee Name: {name}");
        Console.WriteLine($"Sales Amount: {performanceData.Sales}");
        Console.WriteLine($"Rating: {performanceData.Rating}");
        Console.WriteLine($"Performance: {category}");
    }
}
