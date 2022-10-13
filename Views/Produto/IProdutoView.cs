namespace AppEngSoft.Views.Produto
{
  internal interface IProdutoView : IViewPadrao
  {
    //Atributos da model/view
    string Id { get; set; }
    string Nome { get; set; }
    string Preco { get; set; }
    string Estoque { get; set; }

    string ProdutoUnidadeID { get; set; }
    string ProdutoUnidadeNome { get; set; }

    string UnidadeID { get; set; } 
    string UnidadeNome { get; set; }

    event EventHandler ProcurarEventoUnidade;
    event EventHandler AdicionarEventoUnidade;
    event EventHandler EditarEventoUnidade;
    event EventHandler DeletarEventoUnidade;
    event EventHandler SalvarEventoUnidade;
    event EventHandler CancelarEventoUnidade;

    //Atributos de comportamento
    bool eEdicaoUnidade { get; set; }

    void LigarFonteDados_Unidades(BindingSource lista);
  }
}
