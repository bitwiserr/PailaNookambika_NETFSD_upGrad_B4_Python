using System;
using System.Collections.Generic;
using System.Linq;

// ✅ Define a Record for Student
public record Student(int RollNumber, string Name, string Course, int Marks);

class Program
{
    static void Main()
    {
        List<Student> students = new List<Student>();

        while (true)
        {
            Console.WriteLine("\n--- Student Record Management System ---");
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. Display All Students");
            Console.WriteLine("3. Search Student by Roll Number");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");

            string choice = Console.ReadLine()!;
            switch (choice)
            {
                case "1":
                    AddStudent(students);
                    break;
                case "2":
                    DisplayStudents(students);
                    break;
                case "3":
                    SearchStudent(students);
                    break;
                case "4":
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    // ✅ Add Student
    static void AddStudent(List<Student> students)
    {
        Console.Write("Enter Roll Number: ");
        if (!int.TryParse(Console.ReadLine(), out int rollNumber) || rollNumber <= 0)
        {
            Console.WriteLine("Invalid Roll Number.");
            return;
        }

        Console.Write("Enter Name: ");
        string name = Console.ReadLine()!;

        Console.Write("Enter Course: ");
        string course = Console.ReadLine()!;

        Console.Write("Enter Marks: ");
        if (!int.TryParse(Console.ReadLine(), out int marks) || marks < 0 || marks > 100)
        {
            Console.WriteLine("Invalid Marks. Must be between 0 and 100.");
            return;
        }

        students.Add(new Student(rollNumber, name, course, marks));
        Console.WriteLine("Student record added successfully!");
    }

    // ✅ Display All Students
    static void DisplayStudents(List<Student> students)
    {
        if (students.Count == 0)
        {
            Console.WriteLine("No student records found.");
            return;
        }

        Console.WriteLine("\nStudent Records:");
        foreach (var student in students)
        {
            Console.WriteLine($"Roll No: {student.RollNumber} | Name: {student.Name} | Course: {student.Course} | Marks: {student.Marks}");
        }
    }

    // ✅ Search Student by Roll Number
    static void SearchStudent(List<Student> students)
    {
        Console.Write("Enter Roll Number to search: ");
        if (!int.TryParse(Console.ReadLine(), out int rollNumber))
        {
            Console.WriteLine("Invalid Roll Number.");
            return;
        }

        var student = students.FirstOrDefault(s => s.RollNumber == rollNumber);
        if (student == null)
        {
            Console.WriteLine("Student record not found.");
        }
        else
        {
            Console.WriteLine("\nSearch Result:");
            Console.WriteLine($"Roll No: {student.RollNumber} | Name: {student.Name} | Course: {student.Course} | Marks: {student.Marks}");
        }
    }
}
