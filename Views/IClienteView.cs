namespace AppEngSoft.Views
{
  internal interface IClienteView
  {
    //Atributos da view
    string Id { get; set; }
    string Nome { get; set; }
    string Email { get; set; }
    string Fone { get; set; }

    string CNPJ { get; set; }
    string InscricaoMunicipal { get; set; }
    string InscricaoEstadual { get; set; }

    string RG { get; set; }
    string CPF { get; set; }


    //Atributos de comportamento
    string Mensagem { get; set; }
    string ValorBusca { get; set; }

    bool SucessoOperacao { get; set; }
    bool eEdicao { get; set; }
    bool ePessoaJuridica { get; set; }
    bool eFeminino { get; set; }


    //Eventos
    event EventHandler ProcurarEvento;
    event EventHandler AdicionarEvento;
    event EventHandler EditarEvento;
    event EventHandler DeletarEvento;
    //event EventHandler DeleteAllEvent;
    //event EventHandler EditAllEvent;
    event EventHandler SalvarEvento;
    event EventHandler CancelarEvento;

    void LigarFonteDados(BindingSource ClientesLista);
    void Show();
  }
}
