using System.ComponentModel;

namespace AppEngSoft.Models
{
  internal class ClienteModel
  {
    [DisplayName("ID")]
    public uint Id { get; set; }

    [DisplayName("Nome")]
    public string Nome { get; set; }

    [DisplayName("E-mail")]
    public string Email { get; set; }

    [DisplayName("Telefone")]
    public string Fone { get; set; }

    [DisplayName("Tipo de Pessoa")]
    public string TipoPessoa { get; set; }

    [DisplayName("Pessoa Juridica")]
    [Browsable(false)]
    public PessoaJuridicaModel Juridica { get; set; }

    [Browsable(false)]
    [DisplayName("Pessoa Fisica")]
    public PessoaFisicaModel Fisica { get; set; }

    public ClienteModel()
    {
      Juridica = new PessoaJuridicaModel();
      Fisica = new PessoaFisicaModel();
    }

    public ClienteModel(uint id, string nome, string email, string fone, string tipoPessoa, PessoaJuridicaModel juridica, PessoaFisicaModel fisica)
    {
      Id = id;
      Nome = nome;
      Email = email;
      Fone = fone;
      TipoPessoa = tipoPessoa;
      Juridica = juridica;
      Fisica = fisica;
    }
  }
}
