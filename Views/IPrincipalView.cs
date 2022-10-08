namespace AppEngSoft.Views
{
  internal interface IPrincipalView
  {
    event EventHandler ExibirClientesView;
    event EventHandler ExibirCategoriasView;
    event EventHandler ExibirVendedoresView;
    event EventHandler ExibirProdutosView;

    void PrepareChildForm(Form childForm);
  }
}
