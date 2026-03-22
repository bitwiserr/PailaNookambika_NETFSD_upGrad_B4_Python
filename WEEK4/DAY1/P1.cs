using System;

class Program
{
    static void Main()
    {
        // Accept student name
        Console.Write("Enter Name: ");
        string name = Console.ReadLine();

        // Accept student marks
        Console.Write("Enter Marks (0-100): ");
        string input = Console.ReadLine();

        // Validate input
        int marks;
        if (!int.TryParse(input, out marks))
        {
            Console.WriteLine("Invalid input! Marks must be a number.");
            return;
        }

        if (marks < 0 || marks > 100)
        {
            Console.WriteLine("Invalid marks! Please enter a value between 0 and 100.");
            return;
        }

        // Determine grade using if-else
        string grade;
        if (marks >= 85)
        {
            grade = "A";
        }
        else if (marks >= 70)
        {
            grade = "B";
        }
        else if (marks >= 55)
        {
            grade = "C";
        }
        else if (marks >= 40)
        {
            grade = "D";
        }
        else
        {
            grade = "Fail";
        }

        // Display result
        Console.WriteLine($"Student: {name}");
        Console.WriteLine($"Grade: {grade}");
    }
}
