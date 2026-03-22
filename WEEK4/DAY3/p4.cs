using System;

class Employee
{
    // Properties
    public string Name { get; set; }
    public double BaseSalary { get; set; }

    // Constructor
    public Employee(string name, double baseSalary)
    {
        Name = name;
        BaseSalary = baseSalary;
    }

    // Virtual method to calculate salary
    public virtual double CalculateSalary()
    {
        return BaseSalary; // Default: no bonus
    }
}

class Manager : Employee
{
    // Constructor
    public Manager(string name, double baseSalary) : base(name, baseSalary) { }

    // Override method
    public override double CalculateSalary()
    {
        return BaseSalary + (BaseSalary * 0.20); // 20% bonus
    }
}

class Developer : Employee
{
    // Constructor
    public Developer(string name, double baseSalary) : base(name, baseSalary) { }

    // Override method
    public override double CalculateSalary()
    {
        return BaseSalary + (BaseSalary * 0.10); // 10% bonus
    }
}

class Program
{
    static void Main()
    {
        // Sample input
        double baseSalary = 50000;

        // Polymorphism: base class reference pointing to derived objects
        Employee manager = new Manager("Alice", baseSalary);
        Employee developer = new Developer("Bob", baseSalary);

        // Display results
        Console.WriteLine($"Manager Salary = {manager.CalculateSalary()}");
        Console.WriteLine($"Developer Salary = {developer.CalculateSalary()}");
    }
}
