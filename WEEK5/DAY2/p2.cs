using System;
using System.IO;

class Program
{
    static void Main()
    {
        Console.Write("Enter folder path: ");
        string folderPath = Console.ReadLine()!;

        try
        {
            if (!Directory.Exists(folderPath))
            {
                Console.WriteLine("Error: The specified directory does not exist.");
                return;
            }

            string[] files = Directory.GetFiles(folderPath);

            if (files.Length == 0)
            {
                Console.WriteLine("No files found in the directory.");
                return;
            }

            Console.WriteLine("\nFile Details:");
            foreach (string file in files)
            {
                FileInfo fi = new FileInfo(file);
                Console.WriteLine($"Name: {fi.Name} | Size: {fi.Length} bytes | Created: {fi.CreationTime}");
            }

            Console.WriteLine($"\nTotal number of files: {files.Length}");
        }
        catch (UnauthorizedAccessException ex)
        {
            Console.WriteLine($"Access denied: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Unexpected error: {ex.Message}");
        }
    }
}
