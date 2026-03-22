using System;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;

class Program
{
    static async Task ValidateOrderAsync()
    {
        Trace.TraceInformation("Step 1: Order validation started...");
        await Task.Delay(1000); // simulate work
        Trace.TraceInformation("Step 1: Order validation completed.");
    }

    static async Task ProcessPaymentAsync()
    {
        Trace.TraceInformation("Step 2: Payment processing started...");
        await Task.Delay(2000); // simulate work
        Trace.TraceInformation("Step 2: Payment processing completed.");
    }

    static async Task UpdateInventoryAsync()
    {
        Trace.TraceInformation("Step 3: Inventory update started...");
        await Task.Delay(1500); // simulate work
        Trace.TraceInformation("Step 3: Inventory update completed.");
    }

    static async Task GenerateInvoiceAsync()
    {
        Trace.TraceInformation("Step 4: Invoice generation started...");
        await Task.Delay(1000); // simulate work
        Trace.TraceInformation("Step 4: Invoice generation completed.");
    }

    static async Task Main()
    {
        // ✅ Configure trace listener to log into a file
        string logFile = "OrderTraceLog.txt";
        using (TextWriterTraceListener listener = new TextWriterTraceListener(logFile))
        {
            Trace.Listeners.Clear(); // remove default listeners
            Trace.Listeners.Add(listener);
            Trace.AutoFlush = true;

            Console.WriteLine("Order processing started. Trace logs will be written to OrderTraceLog.txt\n");

            await ValidateOrderAsync();
            await ProcessPaymentAsync();
            await UpdateInventoryAsync();
            await GenerateInvoiceAsync();

            Trace.WriteLine("Order processing completed successfully.");
            Console.WriteLine("Order processing completed. Check OrderTraceLog.txt for detailed trace logs.");
        }
    }
}
