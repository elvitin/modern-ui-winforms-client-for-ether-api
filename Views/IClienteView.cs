namespace AppEngSoft.Views
{
  internal interface IClienteView
  {
    //Fields
    string Id { get; set; }
    string Nome { get; set; }
    string Email { get; set; }
    string Fone { get; set; }
    //string TipoPessoa { get; set; }

    event EventHandler ProcurarEvento;
    event EventHandler AdicionarEvento;
    event EventHandler RemoverEvento;
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
