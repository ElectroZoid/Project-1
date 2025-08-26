using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp;

public class BankAccount
{
    private decimal _balance;

    public BankAccount(decimal initial)
    {
        if (initial < 0)
        {
            Console.WriteLine("Warning: Negative initial balance not allowed. Setting to 0.");
            _balance = 0m;
        }
        else
        {
            _balance = initial;
        }

        Console.WriteLine($"Bank Account created with balance : {_balance}");
    }

    public decimal GetBalance()
    {
        return _balance;
    }

    public void Deposit(decimal amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Deposit amount must be positive.");
            return;
        }

        _balance += amount;
        Console.WriteLine($"Deposited: {amount}, New Balance: {_balance}");
    }

    public void Withdraw(decimal amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Withdrawal amount must be positive.");
            return;
        }

        if (amount > _balance)
        {
            Console.WriteLine("Insufficient funds! Withdrawal denied.");
            return;
        }

        _balance -= amount;
        Console.WriteLine($"Withdrawn: {amount}, New Balance: {_balance}");
    }

}
