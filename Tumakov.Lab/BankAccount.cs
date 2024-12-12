using System;

public class BankAccount
{
    private static int accountCounter = 0; 

    private readonly int accountNumber; 
    private decimal balance; 
    private string accountType; 
    public BankAccount(string accountType)
    {
        accountCounter++;
        this.accountNumber = accountCounter; 
        this.balance = 0.0m; 
        this.accountType = accountType; 
    }

    public void Deposit(decimal amount)
    {
        if (amount > 0)
        {
            balance += amount;
            Console.WriteLine($"На счет {accountNumber} положено {amount}. Новый баланс: {balance}.");
        }
        else
        {
            Console.WriteLine("Сумма пополнения должна быть положительной.");
        }
    }

    public void Withdraw(decimal amount)
    {
        if (amount > 0 && amount <= balance)
        {
            balance -= amount;
            Console.WriteLine($"Со счета {accountNumber} снято {amount}. Новый баланс: {balance}.");
        }
        else if (amount > balance)
        {
            Console.WriteLine("Недостаточно средств на счете.");
        }
        else
        {
            Console.WriteLine("Сумма снятия должна быть положительной.");
        }
    }

    public static void Transfer(BankAccount fromAccount, BankAccount toAccount, decimal amount)
    {
        if (fromAccount != null && toAccount != null)
        {
            if (amount > 0 && amount <= fromAccount.balance)
            {
                fromAccount.Withdraw(amount);
                toAccount.Deposit(amount);
                Console.WriteLine($"Переведено {amount} со счета {fromAccount.accountNumber} на счет {toAccount.accountNumber}.");
            }
            else if (amount > fromAccount.balance)
            {
                Console.WriteLine("Недостаточно средств на счете для перевода.");
            }
            else
            {
                Console.WriteLine("Сумма перевода должна быть положительной.");
            }
        }
        else
        {
            Console.WriteLine("Некорректные объекты счетов.");
        }
    }

    public decimal GetBalance()
    {
        return balance;
    }

    public int GetAccountNumber()
    {
        return accountNumber;
    }
}
