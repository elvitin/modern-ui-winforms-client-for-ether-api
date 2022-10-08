namespace AppEngSoft.Views.Cliente
{
  internal interface IClienteView : IViewPadrao
  {
    //Atributos da model/view
    string Id { get; set; }
    string Nome { get; set; }
    string Email { get; set; }
    string Fone { get; set; }

    string CNPJ { get; set; }
    string InscricaoMunicipal { get; set; }
    string InscricaoEstadual { get; set; }

    string RG { get; set; }
    string CPF { get; set; }

    bool ePessoaJuridica { get; set; }
    bool eFeminino { get; set; }
  }
}
