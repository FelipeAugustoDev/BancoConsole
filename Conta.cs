using System;
class Conta : Users
{
  private string Titular;
  private string Cpf; //comparar o dono da conta
  private decimal Saldo;//utilizado para retirada de dinheiro
  private string Agencia;//armazenar a qual agencia essa conta faz parte


  public void Dados(string Agence, decimal MyMoney)
  {
    this.Titular = Nome;
    this.Cpf = CPF;
    this.Agencia = Agence;
    this.Saldo = MyMoney;
  }
  ///sumary
  ///Deposito De valor na conta
  ///sumary
  public void Deposito(decimal valor)
  {
    Saldo += valor;
  }

  ///sumary
  ///Retirada De valor na conta
  ///sumary
  public void Saque(decimal valor)
  {

    if (valor > Saldo)
    {
      Console.WriteLine("SALDO INSUFICIENTE!");
      return;
    }
    else { Saldo -= valor; }
  }
  public void SaldoConta()
  {
    Console.WriteLine($"Seu saldo atual é: {Saldo.ToString()}");
  }
}