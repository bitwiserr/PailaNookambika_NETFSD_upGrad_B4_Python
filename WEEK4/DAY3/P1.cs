using System;

class Student
{
    // Method to calculate average
    public double CalculateAverage(int m1, int m2, int m3)
    {
        double average = (m1 + m2 + m3) / 3.0; // use 3.0 to avoid integer division
        return average;
    }

    // Method to determine grade based on average
    public string GetGrade(double average)
    {
        if (average >= 85)
            return "A";
        else if (average >= 70)
            return "B";
        else if (average >= 55)
            return "C";
        else if (average >= 40)
            return "D";
        else
            return "Fail";
    }
}

class Program
{
    static void Main()
    {
        // Input marks
        Console.Write("Enter marks for subject 1: ");
        int m1 = int.Parse(Console.ReadLine()!);

        Console.Write("Enter marks for subject 2: ");
        int m2 = int.Parse(Console.ReadLine()!);

        Console.Write("Enter marks for subject 3: ");
        int m3 = int.Parse(Console.ReadLine()!);

        // Create Student object
        Student student = new Student();

        // Calculate average
        double avg = student.CalculateAverage(m1, m2, m3);

        // Get grade
        string grade = student.GetGrade(avg);

        // Display result
        Console.WriteLine($"Average = {avg}, Grade = {grade}");
    }
}
