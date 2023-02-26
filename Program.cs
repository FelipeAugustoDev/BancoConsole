using System;

namespace Bank_Console
{
  public class Program
  {
    static void Main(string[] args)
    {
      Users users = new Users();
      Conta conta = new Conta();

      decimal Saldo;
      Console.WriteLine("Digite seu:\nNome\nSobrenome\nCPF\nEndereco\nTelefone\nAgencia\nSaldo");

      void dados()
      {
        users.Nome = Console.ReadLine();
        users.Sobrenome = Console.ReadLine();
        users.CPF = Console.ReadLine();
        users.Endereco = Console.ReadLine();
        users.Telefone = Console.ReadLine();
        string Agencia = Console.ReadLine();
        Saldo = decimal.Parse(Console.ReadLine());
        conta.Dados(Agencia, Saldo);
      }

      dados();
      Console.WriteLine("Digite o Tipo de Operação que deseja:\n1 - Saque\n2 - Deposito\n3 - Saldo");

      switch (Console.ReadLine())
      {
        case "1":
          Console.WriteLine("Digite o valor que deseja sacar:");
          decimal valor = decimal.Parse(Console.ReadLine());
          conta.Saque(valor);
          conta.SaldoConta();
          break;

        case "2":
          Console.WriteLine("Digite o valor que deseja Depositar:");
          decimal valor1 = decimal.Parse(Console.ReadLine());
          conta.Deposito(valor1);
          conta.SaldoConta();
          break;
        case "3":
          conta.SaldoConta();
          break;

        default:
          return;
      }
      Console.ReadKey();
    }
  }
}