using AppEngSoft.Models;
using AppEngSoft.Models.Vendedor;
using AppEngSoft.Repositorios;
using AppEngSoft.Repositorios.Vendedor;
using AppEngSoft.Views;
using AppEngSoft.Views.Vendedor;

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
      this.principalView.ExibirVendedoresView += ExibirVendedoresView;
    }

    private void ExibirVendedoresView(object? sender, EventArgs e)
    {
      IVendedorView view = VendedorView.ObterInstancia();
      principalView.PrepareChildForm((Form)view);
      IVendedorRepositorio repositorio = new VendedorRepositorio(connStr);
      new VendedorPresenter(view, repositorio);
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
