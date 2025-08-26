namespace BankApp;

internal class Program
{
    static void Main()
    {
        // Simple scenario to test the fucntions 
        // provided by class BankAccount.cs
        BankAccount account = new BankAccount(1000m);

        account.Deposit(500m);
        account.Withdraw(200m);
        account.Withdraw(2000m);

        Console.WriteLine($"Final Balance: {account.GetBalance()}");
    }
}
