using System;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    static void GenerateSalesReport()
    {
        Console.WriteLine("Sales Report started...");
        Thread.Sleep(3000); // simulate processing
        Console.WriteLine("Sales Report completed.");
    }

    static void GenerateInventoryReport()
    {
        Console.WriteLine("Inventory Report started...");
        Thread.Sleep(2000); // simulate processing
        Console.WriteLine("Inventory Report completed.");
    }

    static void GenerateCustomerReport()
    {
        Console.WriteLine("Customer Report started...");
        Thread.Sleep(4000); // simulate processing
        Console.WriteLine("Customer Report completed.");
    }

    static void Main()
    {
        Console.WriteLine("Starting report generation...\n");

        // Run tasks concurrently
        Task t1 = Task.Run(() => GenerateSalesReport());
        Task t2 = Task.Run(() => GenerateInventoryReport());
        Task t3 = Task.Run(() => GenerateCustomerReport());

        // Wait for all tasks to finish
        Task.WaitAll(t1, t2, t3);

        Console.WriteLine("\nAll reports have been generated successfully!");
    }
}
