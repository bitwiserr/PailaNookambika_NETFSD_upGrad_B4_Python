using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter Product Name: ");
        string productName = Console.ReadLine()!;

        Console.Write("Enter Product Price: ");
        if (!double.TryParse(Console.ReadLine(), out double price) || price < 0)
        {
            Console.WriteLine("Invalid price entered.");
            return;
        }

        Console.Write("Enter Discount Percentage: ");
        if (!double.TryParse(Console.ReadLine(), out double discount) || discount < 0 || discount > 100)
        {
            Console.WriteLine("Invalid discount percentage entered.");
            return;
        }

        // ✅ Correct formula
        double finalPrice = price - (price * discount / 100);

        // Debugging tip: Place a breakpoint here and inspect `price`, `discount`, and `finalPrice`
        Console.WriteLine("\n--- Product Price Report ---");
        Console.WriteLine($"Product: {productName}");
        Console.WriteLine($"Original Price: {price}");
        Console.WriteLine($"Discount: {discount}%");
        Console.WriteLine($"Final Price: {finalPrice}");
    }
}
