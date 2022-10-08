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

    void LigarFonteDados_Unidades(BindingSource lista);
  }
}
