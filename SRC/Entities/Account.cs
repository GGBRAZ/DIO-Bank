using DIO_Bank.SRC.Enums;

namespace DIO_Bank.SRC.Entities
{
  public class Account
  {
    public Account(string name, double balance, double credit, AccountTypes accountType)
    {
      Name = name;
      Balance = balance;
      Credit = credit;
      AccountType = accountType;
    }

    public string Name { get; private set; }
    public double Balance { get; private set; }
    public double Credit { get; private set; }
    public AccountTypes AccountType { get; private set; }

    public bool Withdraw(double value)
    {
      if (this.Balance - value < this.Credit * .1)
      {
        System.Console.WriteLine("Saldo Insuficiente!");
        return false;
      }
      this.Balance -= value;
      System.Console.WriteLine("Seu saldo atual Sr.:{0} é:{1}",
      this.Name, this.Balance);
      return true;
    }

    public void Deposit(double value)
    {
      this.Balance += value;
      System.Console.WriteLine("Sr.:{0} seu saldo atual é:{1}",
      this.Name, this.Balance);
    }

    public void Transfer(double value, Account destination)
    {
      if (this.Withdraw(value))
      {
        destination.Deposit(value);
      }
    }

    public override string ToString()
    {
      return $"Nome:{Name}, Saldo:{Balance}, Crédito:{Credit}, Tipo da Conta:{AccountType}";
    }
  }
}