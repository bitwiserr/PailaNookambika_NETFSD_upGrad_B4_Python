using System;

class BankAccount
{
    // Private field
    private double balance;

    // Deposit method
    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            balance += amount;
            Console.WriteLine($"Deposited {amount}. Current Balance = {balance}");
        }
        else
        {
            Console.WriteLine("Deposit amount must be positive.");
        }
    }

    // Withdraw method
    public void Withdraw(double amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Withdrawal amount must be positive.");
        }
        else if (amount > balance)
        {
            Console.WriteLine("Insufficient balance. Withdrawal denied.");
        }
        else
        {
            balance -= amount;
            Console.WriteLine($"Withdrew {amount}. Current Balance = {balance}");
        }
    }

    // GetBalance method
    public double GetBalance()
    {
        return balance;
    }
}
class Program
{
    static void Main()
    {
        BankAccount account = new BankAccount();

        // Sample operations
        account.Deposit(5000);
        account.Withdraw(800);

        Console.WriteLine($"Final Balance = {account.GetBalance()}");
    }
}
