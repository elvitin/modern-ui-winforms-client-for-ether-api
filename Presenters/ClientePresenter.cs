using AppEngSoft.Models;
using AppEngSoft.Views;
using System.Drawing.Design;

namespace AppEngSoft.Presenters
{
  internal class ClientePresenter
  {
    private IClienteView view;
    private IClienteRepositorio repositorio;
    private BindingSource ClientesBinding;
    private IEnumerable<ClienteModel> clientes;

    public ClientePresenter(IClienteView view, IClienteRepositorio repositorio)
    {
      ClientesBinding = new();
      this.view = view;
      this.repositorio = repositorio;

      //Assinando eventos
      view.ProcurarEvento += ProcurarCliente;
      view.EditarEvento += CarregarEditarCliente;

      //Ligando fonte de dados
      view.LigarFonteDados(ClientesBinding);

      //Carregando Lista
      AtualizarListaClientes();

      //Exibindo view
      view.Show();
    }

    private void CarregarEditarCliente(object? sender, EventArgs e)
    {
      ClienteModel cliente = (ClienteModel) ClientesBinding.Current;
      
      view.Id = cliente.Id.ToString();
      view.Nome = cliente.Nome;
      view.Fone = cliente.Fone;
      view.Email = cliente.Nome;
      //view.TipoPessoa = cliente.TipoPessoa;
    }

    private void AtualizarListaClientes()
    {
      clientes = repositorio.ObterTodos();
      ClientesBinding.DataSource = clientes;
    }

    private void ProcurarCliente(object? sender, EventArgs e)
    {
    }
  }
}
