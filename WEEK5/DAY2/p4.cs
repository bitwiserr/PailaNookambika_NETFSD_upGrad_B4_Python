using System;
using System.IO;

class Program
{
    static void Main()
    {
        Console.Write("Enter root directory path: ");
        string rootPath = Console.ReadLine()!;

        try
        {
            DirectoryInfo rootDir = new DirectoryInfo(rootPath);

            if (!rootDir.Exists)
            {
                Console.WriteLine("Error: The specified directory does not exist.");
                return;
            }

            // Get all subdirectories
            DirectoryInfo[] subDirs = rootDir.GetDirectories();

            if (subDirs.Length == 0)
            {
                Console.WriteLine("No subdirectories found in the given root directory.");
                return;
            }

            Console.WriteLine("\n--- Project Structure Analysis ---");
            foreach (DirectoryInfo dir in subDirs)
            {
                try
                {
                    int fileCount = dir.GetFiles().Length;
                    Console.WriteLine($"Folder: {dir.Name} | Files: {fileCount}");
                }
                catch (UnauthorizedAccessException)
                {
                    Console.WriteLine($"Folder: {dir.Name} | Access Denied");
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Unexpected error: {ex.Message}");
        }
    }
}
