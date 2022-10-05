namespace AppEngSoft.Views
{
  internal interface IPrincipalView
  {
    event EventHandler ExibirClientesView;
    event EventHandler ExibirCategoriasView;
    event EventHandler ExibirVendedoresView;


    void PrepareChildForm(Form childForm);
  }
}
