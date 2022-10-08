using AppEngSoft.Models.Cliente;
using AppEngSoft.Models.Produto;
using AppEngSoft.Models.Vendedor;
using AppEngSoft.Repositorios.Cliente;
using AppEngSoft.Repositorios.Produto;
using AppEngSoft.Repositorios.Vendedor;
using AppEngSoft.Views;
using AppEngSoft.Views.Cliente;
using AppEngSoft.Views.Produto;
using AppEngSoft.Views.Vendedor;

namespace AppEngSoft.Presenters
{
  internal class PrincipalPresenter
  {
    private readonly IPrincipalView principalView;
    private readonly string connStr;

    public PrincipalPresenter(IPrincipalView principalView, string connStr)
    {
      this.principalView = principalView;
      this.connStr = connStr;
      this.principalView.ExibirClientesView += ExibirClientesView;
      this.principalView.ExibirVendedoresView += ExibirVendedoresView;
      this.principalView.ExibirProdutosView += ExibirProdutosView;
    }

    private void ExibirProdutosView(object? sender, EventArgs e)
    {
      IProdutoView view = ProdutoView.ObterInstancia();
      principalView.PrepareChildForm((Form)view);
      IProdutoRepositorio produtoRepositorio = new ProdutoRepositorio(connStr);
      IUnidadeRepositorio unidadeRepositorio = new UnidadeRepositorio(connStr);

      _ = new ProdutoPresenter(view, produtoRepositorio, unidadeRepositorio);
    }

    private void ExibirVendedoresView(object? sender, EventArgs e)
    {
      IVendedorView view = VendedorView.ObterInstancia;
      principalView.PrepareChildForm((Form)view);
      IVendedorRepositorio repositorio = new VendedorRepositorio(connStr);
      _ = new VendedorPresenter(view, repositorio);
    }

    private void ExibirClientesView(object? sender, EventArgs e)
    {
      IClienteView view = ClienteView.ObterInstancia();
      principalView.PrepareChildForm((Form)view);
      IClienteRepositorio repositorio = new ClienteRepositorio(connStr);
      _ = new ClientePresenter(view, repositorio);
    }
  }
}
