using System.ComponentModel;

namespace AppEngSoft.Models
{
  internal class PessoaFisicaModel
  {
    [DisplayName("CPF")]
    public string Cpf { get; set; }

    [DisplayName("RG")]
    public string Rg { get; set; }

    [DisplayName("Sexo")]
    public string Sexo { get; set; }

    [DisplayName("ID Cliente")]
    public uint ClienteId { get; set; }

    public PessoaFisicaModel()
    {
    }

    public PessoaFisicaModel(string cpf, string rg, string sexo, uint clienteId)
    {
      Cpf = cpf;
      Rg = rg;
      Sexo = sexo;
      ClienteId = clienteId;
    }
  }
}
