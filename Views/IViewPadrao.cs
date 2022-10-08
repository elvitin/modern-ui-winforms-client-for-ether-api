namespace AppEngSoft.Views
{
  public interface IViewPadrao
  {
    //Atributos de comportamento
    string Mensagem { get; set; }
    string ValorBusca { get; set; }

    bool eSucessoOperacao { get; set; }
    bool eEdicao { get; set; }

    //Eventos
    event EventHandler ProcurarEvento;
    event EventHandler AdicionarEvento;
    event EventHandler EditarEvento;
    event EventHandler DeletarEvento;
    event EventHandler SalvarEvento;
    event EventHandler CancelarEvento;

    //Metodo Singleton
    //implementar em classe abstrata 

    //Metodos padrao para toda view baseada em uma entidade
    void LigarFonteDados(BindingSource lista);
    void TrocarPainel(Panel atual, Panel novo);
    void AssociarEventos();
    void Show();
  }
}
