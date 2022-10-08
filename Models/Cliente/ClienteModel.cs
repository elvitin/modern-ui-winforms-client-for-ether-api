using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AppEngSoft.Models.Cliente
{
  internal class ClienteModel
  {
    [DisplayName("ID")]
    public uint Id { get; set; }

    [DisplayName("Nome")]
    [Required(ErrorMessage = "Nome do cliente é obrigatório!")]
    [StringLength(50, MinimumLength = 3, ErrorMessage = "O nome tem que ter no mínimo 3 e no máximo 50 caracteres!")]
    public string Nome { get; set; }

    [Required(ErrorMessage = "E-mail do cliente é obrigatório!")]
    [DisplayName("E-mail")]
    [EmailAddress(ErrorMessage = "Formato do e-mail inválido\ncertifique-se de incluir o caractere: \"@\"")]
    [StringLength(50, MinimumLength = 3, ErrorMessage = "O e-mail tem que ter no mínimo 3 e no máximo 50 caracteres!")]
    public string Email { get; set; }


    [DisplayName("Telefone")]
    [Required(ErrorMessage = "Telefone do cliente é obrigatório!")]
    [DataType(DataType.PhoneNumber, ErrorMessage = "O telefone é inválido!")]
    public string Fone { get; set; }

    [DisplayName("Tipo de Pessoa")]
    [Required(ErrorMessage = "Tipo do cliente é obrigatório!")]
    public string TipoPessoa { get; set; }

    
    [Browsable(false)]
    //[DisplayName("Pessoa Juridica")]
    public PessoaJuridicaModel Juridica { get; set; }

    [Browsable(false)]
    //[DisplayName("Pessoa Fisica")]
    public PessoaFisicaModel Fisica { get; set; }

    public ClienteModel()
    {
      Juridica = new PessoaJuridicaModel();
      Fisica = new PessoaFisicaModel();
    }

    public ClienteModel(uint id, string nome, string email, string fone, string tipoPessoa, PessoaJuridicaModel juridica, PessoaFisicaModel fisica)
    {
      Id = id;
      Email = nome;
      Email = email;
      Fone = fone;
      TipoPessoa = tipoPessoa;
      Juridica = juridica;
      Fisica = fisica;
    }
  }
}
