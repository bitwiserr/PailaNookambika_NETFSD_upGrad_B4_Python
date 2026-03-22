using System;

class Program
{
    static void Main()
    {
        // Accept number N
        Console.Write("Enter Number: ");
        string input = Console.ReadLine();
        int N;

        if (!int.TryParse(input, out N) || N < 1)
        {
            Console.WriteLine("Invalid input! Please enter a positive integer greater than 0.");
            return;
        }

        // Counters and accumulator
        int evenCount = 0;
        int oddCount = 0;
        int sum = 0;

        // Loop from 1 to N
        for (int i = 1; i <= N; i++)
        {
            sum += i;

            if (i % 2 == 0)
                evenCount++;
            else
                oddCount++;
        }

        // Display results
        Console.WriteLine($"Even Count: {evenCount}");
        Console.WriteLine($"Odd Count: {oddCount}");
        Console.WriteLine($"Sum: {sum}");
    }
}
