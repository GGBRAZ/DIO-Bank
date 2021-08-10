using System;
using System.Collections.Generic;
using DIO_Bank.SRC.Entities;
using DIO_Bank.SRC.Enums;

namespace DIO_Bank
{
  class Program
  {
    static List<Account> accounts = new List<Account>();

    static void Main(string[] args)
    {
      string opcaoUsuario = ObterOpcaoUsuario();

      while (opcaoUsuario.ToUpper() != "X")
      {
        switch (opcaoUsuario.ToUpper())
        {
          case "1":
            ListarContas();
            break;
          case "2":
            InsertAccount();
            break;
          case "3":
            Transferir();
            break;
          case "4":
            Sacar();
            break;
          case "5":
            Depositar();
            break;
          case "C":
            Console.Clear();
            break;
          default:
            throw new ArgumentOutOfRangeException();
        }
        opcaoUsuario = ObterOpcaoUsuario();
      }
      Console.WriteLine("Obrigado por utilizar nossos serviços.");
      Console.ReadLine();

    }
    private static void Transferir()
    {
      System.Console.WriteLine("Informe o número da conta de origem");
      int indexFromAccount = int.Parse(Console.ReadLine());
      System.Console.WriteLine("Informe o número da conta de destino");
      int indexToAccount = int.Parse(Console.ReadLine());
      System.Console.WriteLine("Digite o valor da transferência:");
      double transferValue = double.Parse(Console.ReadLine());
      accounts[indexFromAccount]
      .Transfer(transferValue, accounts[indexToAccount]);
    }

    private static void Depositar()
    {
      System.Console.WriteLine("Digite o número da conta:");
      int indexAccount = int.Parse(Console.ReadLine());
      System.Console.WriteLine("Digite o valor a ser depositado:");
      double depositValue = double.Parse(Console.ReadLine());
      accounts[indexAccount].Deposit(depositValue);
    }

    private static void Sacar()
    {
      System.Console.WriteLine("Digite o número da conta:");
      int indexAccount = int.Parse(Console.ReadLine());
      System.Console.WriteLine("Digite o valor a ser sacado:");
      double withdrawValue = double.Parse(Console.ReadLine());
      accounts[indexAccount].Withdraw(withdrawValue);
    }

    private static void ListarContas()
    {
      System.Console.WriteLine("Listar Contas:");
      if (accounts.Count == 0)
      {
        System.Console.WriteLine("Não há contas cadastradas.");
        return;
      }

      for (int i = 0; i < accounts.Count; i++)
      {
        Account account = accounts[i];
        Console.WriteLine("#{0} - ", i);
        System.Console.WriteLine(account);
      }

      ObterOpcaoUsuario();
    }

    private static void InsertAccount()
    {
      System.Console.WriteLine("Inserir Nova Conta!");
      System.Console.WriteLine("Digite 1 para Pessoa Física ou 2 Para Pessoa Juridica.");
      int optionAccountType = int.Parse(Console.ReadLine());
      System.Console.WriteLine("Digite o nome do cliente.");
      string clientName = Console.ReadLine().ToUpper();
      System.Console.WriteLine("Digite o saldo inicial.");
      double initialBalance = double.Parse(Console.ReadLine());
      System.Console.WriteLine("Digite o crédito inicial.");
      double initialCredit = double.Parse(Console.ReadLine());
      Account newAccount = new Account(clientName,
      initialBalance, initialCredit, (AccountTypes)optionAccountType);
      accounts.Add(newAccount);

    }

    private static string ObterOpcaoUsuario()
    {
      System.Console.WriteLine();
      System.Console.WriteLine("DIO BANK a seu dispor!!!");
      System.Console.WriteLine("Informe a opção desejada");
      System.Console.WriteLine("1- Listar contas");
      System.Console.WriteLine("2- Inserir nova conta");
      System.Console.WriteLine("3- Transferir");
      System.Console.WriteLine("4- Sacar");
      System.Console.WriteLine("5- Depositar");
      System.Console.WriteLine("C- Limpar a tela");
      System.Console.WriteLine("X- Sair");
      System.Console.WriteLine();

      string opcaoUsuario = Console.ReadLine().ToUpper();
      System.Console.WriteLine();
      return opcaoUsuario;
    }
  }
}
