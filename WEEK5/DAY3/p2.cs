using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;

class Program
{
    // ✅ Asynchronous log writer
    static async Task WriteLogAsync(string message)
    {
        Console.WriteLine($"Logging started: {message}");

        // Simulate file writing delay
        await Task.Delay(2000);

        try
        {
            using (FileStream fs = new FileStream("asyncLog.txt", FileMode.Append, FileAccess.Write, FileShare.None, 4096, true))
            {
                byte[] data = Encoding.UTF8.GetBytes(message + Environment.NewLine);
                await fs.WriteAsync(data, 0, data.Length);
            }

            Console.WriteLine($"Logging completed: {message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error writing log: {ex.Message}");
        }
    }

    static async Task Main()
    {
        Console.WriteLine("Application started. Logging asynchronously...\n");

        // Simulate multiple events being logged
        Task t1 = WriteLogAsync("Event 1: User logged in");
        Task t2 = WriteLogAsync("Event 2: Transaction processed");
        Task t3 = WriteLogAsync("Event 3: User logged out");

        // Await all tasks concurrently
        await Task.WhenAll(t1, t2, t3);

        Console.WriteLine("\nAll logs written successfully!");
    }
}
