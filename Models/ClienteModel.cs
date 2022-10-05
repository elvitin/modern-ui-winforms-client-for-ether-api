namespace AppEngSoft.Models
{
  internal class ClienteModel
  {
    private uint id;
    private string nome;
    private string email;
    private string fone;
    private string tipoPessoa;

    [System.ComponentModel.DisplayName("ID")]
    public uint Id { get => id; set => id = value; }

    [System.ComponentModel.DisplayName("Nome")]
    public string Nome { get => nome; set => nome = value; }

    [System.ComponentModel.DisplayName("E-mail")]
    public string Email { get => email; set => email = value; }

    [System.ComponentModel.DisplayName("Telefone")]
    public string Fone { get => fone; set => fone = value; }

    [System.ComponentModel.DisplayName("Tipo de Pessoa")]
    public string TipoPessoa { get => tipoPessoa; set => tipoPessoa = value; }
  }
}
