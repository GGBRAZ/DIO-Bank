using System;

namespace DIO_Bank
{
  class Program
  {
    static void Main(string[] args)
    {
      string opcaoUsuario = ObterOpcaoUsuario();
      while (opcaoUsuario.ToUpper() != "X")
      {
        switch (opcaoUsuario)
        {
          case "1":
            // ListarContas();
            break;
          case "2":
            // InserirConta();
            break;
          case "3":
            // Transferir();
            break;
          case "4":
            // Sacar();
            break;
          case "5":
            // Depositar();
            break;
          case "C":
            Console.Clear();
            break;
          default:
            throw new ArgumentOutOfRangeException();
        }
      }
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
