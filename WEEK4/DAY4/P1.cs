using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Sample Input
        int[] marks = { 78, 85, 90, 67, 88 };
        int threshold = 80;

        // ✅ Total using LINQ's Sum (similar to reduce)
        int total = marks.Sum();

        // ✅ Average
        double average = marks.Average();

        // ✅ Highest score
        int highest = marks.Max();

        // ✅ Count of students above threshold using LINQ's Where (similar to filter)
        int aboveThreshold = marks.Where(score => score > threshold).Count();

        // ✅ Subject-wise highest marks using Dictionary
        // (Here we assume subjects are indexed as Subject1, Subject2, etc.)
        Dictionary<string, int> subjectHighest = new Dictionary<string, int>();
        for (int i = 0; i < marks.Length; i++)
        {
            subjectHighest.Add($"Subject{i + 1}", marks[i]);
        }

        // Display Results
        Console.WriteLine($"Total Marks: {total}");
        Console.WriteLine($"Average Marks: {average}");
        Console.WriteLine($"Students above {threshold}: {aboveThreshold}");
        Console.WriteLine($"Highest Score: {highest}");
        Console.WriteLine("Subject-wise Highest Marks:");
        foreach (var kvp in subjectHighest)
        {
            Console.WriteLine($"{kvp.Key}: {kvp.Value}");
        }
    }
}
