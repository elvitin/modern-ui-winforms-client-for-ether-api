using AppEngSoft.Models;
using AppEngSoft.Repositorios;
using AppEngSoft.Views;

namespace AppEngSoft.Presenters
{
  internal class PrincipalPresenter
  {
    private IPrincipalView principalView;
    private readonly string connStr;

    public PrincipalPresenter(IPrincipalView principalView, string connStr)
    {
      this.principalView = principalView;
      this.connStr = connStr;
      this.principalView.ExibirClientesView += ExibirClientesView;
    }

    private void ExibirClientesView(object? sender, EventArgs e)
    {
      IClienteView view = ClienteView.ObterInstancia();
      principalView.PrepareChildForm((Form)view);
      IClienteRepositorio repositorio = new ClienteRepositorio(connStr);
      new ClientePresenter(view, repositorio);
    }
  }
}
