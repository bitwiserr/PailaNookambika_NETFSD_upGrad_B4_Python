using System;
using System.Threading.Tasks;

class Program
{
    // ✅ Step 1: Verify Payment
    static async Task VerifyPaymentAsync()
    {
        Console.WriteLine("Payment verification started...");
        await Task.Delay(2000); // simulate delay
        Console.WriteLine("Payment verification completed.");
    }

    // ✅ Step 2: Check Inventory
    static async Task CheckInventoryAsync()
    {
        Console.WriteLine("Inventory check started...");
        await Task.Delay(3000); // simulate delay
        Console.WriteLine("Inventory check completed.");
    }

    // ✅ Step 3: Confirm Order
    static async Task ConfirmOrderAsync()
    {
        Console.WriteLine("Order confirmation started...");
        await Task.Delay(1500); // simulate delay
        Console.WriteLine("Order confirmation completed.");
    }

    // ✅ Main workflow
    static async Task Main()
    {
        Console.WriteLine("Order processing initiated...\n");

        // Execute steps in logical order
        await VerifyPaymentAsync();
        await CheckInventoryAsync();
        await ConfirmOrderAsync();

        Console.WriteLine("\nOrder has been processed successfully!");
    }
}
