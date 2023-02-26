using System;
class Users
{
  private string _name;
  private string _sobrenome;
  private string _cpf;
  private string _endereco;
  private string _telefone;


  public string Nome
  {
    get { return _name; }
    set { _name = value; }
  }
  public string Sobrenome
  {
    get { return _sobrenome; }
    set { _sobrenome = value; }
  }

  public string CPF
  {
    get { return _cpf; }
    set { _cpf = value; }
  }
  public string Endereco
  {
    get { return _endereco; }
    set { _endereco = value; }
  }
  public string Telefone
  {
    get { return _telefone; }
    set { _telefone = value; }
  }
  public Users() { }

}
