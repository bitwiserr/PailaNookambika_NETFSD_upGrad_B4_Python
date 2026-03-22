using System;

// ✅ Custom Exception
public class InsufficientBalanceException : Exception
{
    public InsufficientBalanceException(string message) : base(message) { }
}

// ✅ BankAccount Class
class BankAccount
{
    private double balance;

    public BankAccount(double initialBalance)
    {
        balance = initialBalance;
    }

    public void Withdraw(double amount)
    {
        if (amount > balance)
        {
            // Throw custom exception
            throw new InsufficientBalanceException("Withdrawal amount exceeds available balance");
        }
        else if (amount <= 0)
        {
            throw new ArgumentException("Withdrawal amount must be positive");
        }
        else
        {
            balance -= amount;
            Console.WriteLine($"Withdrawal successful. Remaining Balance = {balance}");
        }
    }

    public double GetBalance()
    {
        return balance;
    }
}

// ✅ Main Program
class Program
{
    static void Main()
    {
        BankAccount account = new BankAccount(3000);

        try
        {
            Console.WriteLine($"Current Balance = {account.GetBalance()}");
            account.Withdraw(5000); // Attempt to withdraw more than balance
        }
        catch (InsufficientBalanceException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Unexpected Error: {ex.Message}");
        }
        finally
        {
            Console.WriteLine("Transaction completed safely.");
        }

        Console.WriteLine("Program continues running...");
    }
}
