namespace AppEngSoft.Views
{
  internal interface IClienteView
  {
    //Atributos da view
    string Id { get; set; }
    string Nome { get; set; }
    string Email { get; set; }
    string Fone { get; set; }
    //string TipoPessoa { get; set; }

    //Atributos de comportamento
    string Mensagem { get; set; }
    bool eEdicao { get; set; }
    bool SucessoOperacao { get; set; }
    string ValorBusca { get; set; }

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
