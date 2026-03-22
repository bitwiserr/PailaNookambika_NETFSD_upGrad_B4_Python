using System;
using System.IO;
using System.Text;

class Program
{
    static void Main()
    {
        string filePath = "log.txt"; // File to store log messages

        while (true)
        {
            Console.Write("Enter a log message (or type 'exit' to quit): ");
            string message = Console.ReadLine()!;

            if (message.ToLower() == "exit")
                break;

            try
            {
                // Open file in append mode
                using (FileStream fs = new FileStream(filePath, FileMode.Append, FileAccess.Write))
                {
                    byte[] data = Encoding.UTF8.GetBytes(message + Environment.NewLine);
                    fs.Write(data, 0, data.Length);
                }

                Console.WriteLine("Message written successfully!");
            }
            catch (IOException ex)
            {
                Console.WriteLine($"File access error: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Operation completed safely.\n");
            }
        }

        Console.WriteLine("Program ended. All messages saved in log.txt");
    }
}
