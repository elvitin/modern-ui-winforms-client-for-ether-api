namespace AppEngSoft.Views.Vendedor
{
  internal interface IVendedorView
  {
    //Atributos da model/view
    public string Id { get; set; }
    public string Nome { get; set; }

    //Atributos de comportamento
    string Mensagem { get; set; }
    string ValorBusca { get; set; }

    bool eSucessoOperacao { get; set; }
    bool eEdicao { get; set; }

    event EventHandler ProcurarEvento;
    event EventHandler AdicionarEvento;
    event EventHandler EditarEvento;
    event EventHandler DeletarEvento;
    event EventHandler SalvarEvento;
    event EventHandler CancelarEvento;
    //event EventHandler DeleteAllEvent;
    //event EventHandler EditAllEvent;

    void LigarFonteDados(BindingSource ClientesLista);
    void AssociarEventos();
    void TrocarPainel(Panel atual, Panel novo);
    void Show();
  }
}
