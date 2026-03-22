using System;

class BankAccount
{
    // Private fields
    private string accountNumber;
    private double balance;

    // Public property for AccountNumber (read-only after initialization)
    public string AccountNumber
    {
        get { return accountNumber; }
        private set { accountNumber = value; }
    }

    // Public property for Balance (read-only outside the class)
    public double Balance
    {
        get { return balance; }
        private set { balance = value; }
    }

    // Constructor to initialize account
    public BankAccount(string accNo, double initialBalance = 0)
    {
        AccountNumber = accNo;
        Balance = initialBalance;
    }

    // Deposit method
    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            Balance += amount;
            Console.WriteLine($"Deposited {amount}. Current Balance = {Balance}");
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
        else if (amount > Balance)
        {
            Console.WriteLine("Insufficient balance. Withdrawal denied.");
        }
        else
        {
            Balance -= amount;
            Console.WriteLine($"Withdrew {amount}. Current Balance = {Balance}");
        }
    }
}

class Program
{
    static void Main()
    {
        // Create account with initial balance
        BankAccount account = new BankAccount("ACC12345", 0);

        // Sample transactions
        account.Deposit(5000);
        account.Withdraw(2000);

        Console.WriteLine($"Final Balance = {account.Balance}");
    }
}
